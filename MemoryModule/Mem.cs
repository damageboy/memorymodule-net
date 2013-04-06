using System.Diagnostics;

namespace MemoryModule
{
  public class Mem
  {
    public static unsafe bool Cmp(byte* src, byte* dest, int len)
    {
      Debug.Assert(len >= 0, "Negative length in memcopy!");

      // It turns out that on AMD64 it is faster to not be careful of alignment issues.
      // On IA64 it is necessary to be careful... Oh well. When we do the IA64 push we
      // can work on this implementation.
#if IA64 
            long dstAlign = 8 - (((long)dest) & 7); // number of bytes to copy before dest is 8-byte aligned
 
            while ((dstAlign > 0) && (len > 0)) 
            {
                *dest++ = *src++; 

                len--;
                dstAlign--;
            } 

            long srcAlign = 8 - (((long)src) & 7); 
 
            if (len > 0)
            { 
                if (srcAlign != 8)
                {
                    if (4 == srcAlign)
                    { 
                        while (len >= 4)
                        { 
                            if (((int*)dest)[0] != ((int*)src)[0]) return false;
                            dest += 4;
                            src  += 4; 
                            len  -= 4;
                        }

                        srcAlign = 2;   // fall through to 2-byte copies 
                    }
 
                    if ((2 == srcAlign) || (6 == srcAlign)) 
                    {
                        while (len >= 2) 
                        {
                            if (((short*)dest)[0] != ((short*)src)[0]) return false;
                            dest += 2;
                            src  += 2; 
                            len  -= 2;
                        } 
                    } 

                    while (len-- > 0) 
                    {
                        if (*dest++ != *src++) return false;
                    }
                } 
                else
                { 
                    if (len >= 16) 
                    {
                        do 
                        {
                            if (((long*)dest)[0] != ((long*)src)[0]) return false;
                            if (((long*)dest)[1] != ((long*)src)[1]) return false;
                            dest += 16; 
                            src += 16;
                        } while ((len -= 16) >= 16); 
                    } 
                    if (len > 0)  // protection against negative len and optimization for len==16*N
                    { 
                       if ((len & 8) != 0)
                       {
                           if (((long*)dest)[0] != ((long*)src)[0]) return false;
                           dest += 8; 
                           src += 8;
                       } 
                       if ((len & 4) != 0) 
                       {
                           if (((int*)dest)[0] != ((int*)src)[0]) return false;
                           dest += 4;
                           src += 4;
                       }
                       if ((len & 2) != 0) 
                       {
                           if (((short*)dest)[0] != ((short*)src)[0]) return false; 
                           dest += 2; 
                           src += 2;
                       } 
                       if ((len & 1) != 0)
                       {
                           if (*dest++ != *src++) return false;
                       } 
                    }
                } 
            }

#else
      // AMD64 implementation uses longs instead of ints where possible
      //
      // <STRIP>This is a faster memcpy implementation, from
      // COMString.cpp.  For our strings, this beat the processor's 
      // repeat & move single byte instruction, which memcpy expands into.
      // (You read that correctly.) 
      // This is 3x faster than a simple while loop copying byte by byte, 
      // for large copies.</STRIP>
      if (len >= 16)
      {
        do
        {
#if AMD64
          if (((long*)dest)[0] != ((long*)src)[0]) return false;
          if (((long*)dest)[1] != ((long*)src)[1]) return false;
#else
          if (((int*)dest)[0] != ((int*)src)[0]) return false;
          if (((int*)dest)[1] != ((int*)src)[1]) return false;
          if (((int*)dest)[2] != ((int*)src)[2]) return false;
          if (((int*)dest)[3] != ((int*)src)[3]) return false;
#endif
          dest += 16;
          src += 16;
        } while ((len -= 16) >= 16);
      }
      if (len > 0) // protection against negative len and optimization for len==16*N
      {
        if ((len & 8) != 0)
        {
#if AMD64
          if (((long*)dest)[0] != ((long*)src)[0]) return false;
#else
          if (((int*)dest)[0] != ((int*)src)[0]) return false;
          if (((int*)dest)[1] != ((int*)src)[1]) return false;
#endif
          dest += 8;
          src += 8;
        }
        if ((len & 4) != 0)
        {
          if (((int*)dest)[0] != ((int*)src)[0]) return false;
          dest += 4;
          src += 4;
        }
        if ((len & 2) != 0)
        {
          if (((short*)dest)[0] != ((short*)src)[0]) return false;
          dest += 2;
          src += 2;
        }
        if ((len & 1) != 0)
          if (*dest++ != *src++) return false;
      }
      return true;
#endif // IA64      
    }

    public static unsafe void Cpy(byte* src, byte* dest, int len)
    {
      Debug.Assert(len >= 0, "Negative length in memcopy!");

      // It turns out that on AMD64 it is faster to not be careful of alignment issues.
      // On IA64 it is necessary to be careful... Oh well. When we do the IA64 push we
      // can work on this implementation.
#if IA64 
            long dstAlign = 8 - (((long)dest) & 7); // number of bytes to copy before dest is 8-byte aligned
 
            while ((dstAlign > 0) && (len > 0)) 
            {
                *dest++ = *src++; 

                len--;
                dstAlign--;
            } 

            long srcAlign = 8 - (((long)src) & 7); 
 
            if (len > 0)
            { 
                if (srcAlign != 8)
                {
                    if (4 == srcAlign)
                    { 
                        while (len >= 4)
                        { 
                            ((int*)dest)[0] = ((int*)src)[0]; 
                            dest += 4;
                            src  += 4; 
                            len  -= 4;
                        }

                        srcAlign = 2;   // fall through to 2-byte copies 
                    }
 
                    if ((2 == srcAlign) || (6 == srcAlign)) 
                    {
                        while (len >= 2) 
                        {
                            ((short*)dest)[0] = ((short*)src)[0];
                            dest += 2;
                            src  += 2; 
                            len  -= 2;
                        } 
                    } 

                    while (len-- > 0) 
                    {
                        *dest++ = *src++;
                    }
                } 
                else
                { 
                    if (len >= 16) 
                    {
                        do 
                        {
                            ((long*)dest)[0] = ((long*)src)[0];
                            ((long*)dest)[1] = ((long*)src)[1];
                            dest += 16; 
                            src += 16;
                        } while ((len -= 16) >= 16); 
                    } 
                    if (len > 0)  // protection against negative len and optimization for len==16*N
                    { 
                       if ((len & 8) != 0)
                       {
                           ((long*)dest)[0] = ((long*)src)[0];
                           dest += 8; 
                           src += 8;
                       } 
                       if ((len & 4) != 0) 
                       {
                           ((int*)dest)[0] = ((int*)src)[0]; 
                           dest += 4;
                           src += 4;
                       }
                       if ((len & 2) != 0) 
                       {
                           ((short*)dest)[0] = ((short*)src)[0]; 
                           dest += 2; 
                           src += 2;
                       } 
                       if ((len & 1) != 0)
                       {
                           *dest++ = *src++;
                       } 
                    }
                } 
            }

#else
      // AMD64 implementation uses longs instead of ints where possible
      //
      // <STRIP>This is a faster memcpy implementation, from
      // COMString.cpp.  For our strings, this beat the processor's 
      // repeat & move single byte instruction, which memcpy expands into.
      // (You read that correctly.) 
      // This is 3x faster than a simple while loop copying byte by byte, 
      // for large copies.</STRIP>
      if (len >= 16) {
        do {
#if AMD64
          ((long*) dest)[0] = ((long*) src)[0];
          ((long*) dest)[1] = ((long*) src)[1];
#else
          ((int*)dest)[0] = ((int*)src)[0];
          ((int*)dest)[1] = ((int*)src)[1];
          ((int*)dest)[2] = ((int*)src)[2];
          ((int*)dest)[3] = ((int*)src)[3];
#endif
          dest += 16;
          src += 16;
        } while ((len -= 16) >= 16);
      }
      if (len > 0) // protection against negative len and optimization for len==16*N
      {
        if ((len & 8) != 0) {
#if AMD64
          ((long*) dest)[0] = ((long*) src)[0];
#else
          ((int*)dest)[0] = ((int*)src)[0];
          ((int*)dest)[1] = ((int*)src)[1];
#endif
          dest += 8;
          src += 8;
        }
        if ((len & 4) != 0) {
          ((int*) dest)[0] = ((int*) src)[0];
          dest += 4;
          src += 4;
        }
        if ((len & 2) != 0) {
          ((short*) dest)[0] = ((short*) src)[0];
          dest += 2;
          src += 2;
        }
        if ((len & 1) != 0)
          *dest++ = *src++;
      }

#endif // IA64
    }
  }
}