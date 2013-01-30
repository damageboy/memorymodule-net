using System;
using System.Runtime.InteropServices;

namespace MemoryModule
{
  public class NativeConstants
  {
    /// __IMAGE_COR20_HEADER_DEFINED__ -> 
    /// Error generating expression: Value cannot be null.
    /// Parameter name: node
    public const string @__IMAGE_COR20_HEADER_DEFINED__ = "";

    /// IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE -> 0x8000
    public const int IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 32768;

    /// IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER -> 11
    public const int IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11;

    /// IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR -> 14
    public const int IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR = 14;

    /// IMAGE_DLLCHARACTERISTICS_NO_ISOLATION -> 0x0200
    public const int IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 512;

    /// IMAGE_DLLCHARACTERISTICS_WDM_DRIVER -> 0x2000
    public const int IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 8192;

    /// IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY -> 1
    public const int IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY = 1;

    /// IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER -> 12
    public const int IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12;

    /// IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP -> 0x0400
    public const int IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 1024;

    /// IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT -> 13
    public const int IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT = 13;

    /// IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT -> 11
    public const int IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT = 11;

    /// IMAGE_DIRECTORY_ENTRY_ARCHITECTURE -> 7
    public const int IMAGE_DIRECTORY_ENTRY_ARCHITECTURE = 7;

    /// IMAGE_SIZEOF_NT_OPTIONAL64_HEADER -> 240
    public const int IMAGE_SIZEOF_NT_OPTIONAL64_HEADER = 240;

    /// IMAGE_SIZEOF_NT_OPTIONAL32_HEADER -> 224
    public const int IMAGE_SIZEOF_NT_OPTIONAL32_HEADER = 224;

    /// IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG -> 10
    public const int IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG = 10;

    /// IMAGE_WEAK_EXTERN_SEARCH_LIBRARY -> 2
    public const int IMAGE_WEAK_EXTERN_SEARCH_LIBRARY = 2;

    /// IMAGE_SYM_CLASS_UNDEFINED_STATIC -> 0x000E
    public const int IMAGE_SYM_CLASS_UNDEFINED_STATIC = 14;

    /// IMAGE_SYM_CLASS_MEMBER_OF_STRUCT -> 0x0008
    public const int IMAGE_SYM_CLASS_MEMBER_OF_STRUCT = 8;

    /// IMAGE_SIZEOF_STD_OPTIONAL_HEADER -> 28
    public const int IMAGE_SIZEOF_STD_OPTIONAL_HEADER = 28;

    /// IMAGE_SCN_CNT_UNINITIALIZED_DATA -> 0x00000080
    public const int IMAGE_SCN_CNT_UNINITIALIZED_DATA = 128;

    /// IMAGE_SIZEOF_ROM_OPTIONAL_HEADER -> 56
    public const int IMAGE_SIZEOF_ROM_OPTIONAL_HEADER = 56;

    /// IMAGE_RESOURCE_DATA_IS_DIRECTORY -> 0x80000000
    public const int IMAGE_RESOURCE_DATA_IS_DIRECTORY = -2147483648;

    /// IMAGE_NUMBEROF_DIRECTORY_ENTRIES -> 16
    public const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

    /// IMAGE_DLLCHARACTERISTICS_NO_BIND -> 0x0800
    public const int IMAGE_DLLCHARACTERISTICS_NO_BIND = 2048;

    /// IMAGE_COMDAT_SELECT_NODUPLICATES -> 1
    public const int IMAGE_COMDAT_SELECT_NODUPLICATES = 1;

    /// IMAGE_SYM_CLASS_UNDEFINED_LABEL -> 0x0007
    public const int IMAGE_SYM_CLASS_UNDEFINED_LABEL = 7;

    /// IMAGE_SYM_CLASS_TYPE_DEFINITION -> 0x000D
    public const int IMAGE_SYM_CLASS_TYPE_DEFINITION = 13;

    /// IMAGE_SYM_CLASS_MEMBER_OF_UNION -> 0x000B
    public const int IMAGE_SYM_CLASS_MEMBER_OF_UNION = 11;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_SYM_CLASS_END_OF_FUNCTION -> "(BYTE) -1"
    public const string IMAGE_SYM_CLASS_END_OF_FUNCTION = "(BYTE) -1";

    /// IMAGE_SUBSYSTEM_EFI_APPLICATION -> 10
    public const int IMAGE_SUBSYSTEM_EFI_APPLICATION = 10;

    /// IMAGE_SIZEOF_NT_OPTIONAL_HEADER -> IMAGE_SIZEOF_NT_OPTIONAL32_HEADER
    public const int IMAGE_SIZEOF_NT_OPTIONAL_HEADER = IMAGE_SIZEOF_NT_OPTIONAL32_HEADER;

    /// IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR -> 60
    public const int IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR = 60;

    /// IMAGE_SEPARATE_DEBUG_FLAGS_MASK -> 0x8000
    public const int IMAGE_SEPARATE_DEBUG_FLAGS_MASK = 32768;

    /// IMAGE_DLLCHARACTERISTICS_NO_SEH -> 0x0400
    public const int IMAGE_DLLCHARACTERISTICS_NO_SEH = 1024;

    /// IMAGE_DIRECTORY_ENTRY_GLOBALPTR -> 8
    public const int IMAGE_DIRECTORY_ENTRY_GLOBALPTR = 8;

    /// IMAGE_DIRECTORY_ENTRY_EXCEPTION -> 3
    public const int IMAGE_DIRECTORY_ENTRY_EXCEPTION = 3;

    /// IMAGE_DIRECTORY_ENTRY_BASERELOC -> 5
    public const int IMAGE_DIRECTORY_ENTRY_BASERELOC = 5;

    /// IMAGE_COMDAT_SELECT_EXACT_MATCH -> 4
    public const int IMAGE_COMDAT_SELECT_EXACT_MATCH = 4;

    /// IMAGE_COMDAT_SELECT_ASSOCIATIVE -> 5
    public const int IMAGE_COMDAT_SELECT_ASSOCIATIVE = 5;

    /// IMAGE_WEAK_EXTERN_SEARCH_ALIAS -> 3
    public const int IMAGE_WEAK_EXTERN_SEARCH_ALIAS = 3;

    /// IMAGE_SYM_CLASS_REGISTER_PARAM -> 0x0011
    public const int IMAGE_SYM_CLASS_REGISTER_PARAM = 17;

    /// IMAGE_SYM_CLASS_MEMBER_OF_ENUM -> 0x0010
    public const int IMAGE_SYM_CLASS_MEMBER_OF_ENUM = 16;

    /// IMAGE_SUBSYSTEM_WINDOWS_CE_GUI -> 9
    public const int IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9;

    /// IMAGE_SUBSYSTEM_NATIVE_WINDOWS -> 8
    public const int IMAGE_SUBSYSTEM_NATIVE_WINDOWS = 8;

    /// IMAGE_SEPARATE_DEBUG_SIGNATURE -> 0x4944
    public const int IMAGE_SEPARATE_DEBUG_SIGNATURE = 18756;

    /// IMAGE_SCN_CNT_INITIALIZED_DATA -> 0x00000040
    public const int IMAGE_SCN_CNT_INITIALIZED_DATA = 64;

    /// IMAGE_REL_BASED_MIPS_JMPADDR16 -> 9
    public const int IMAGE_REL_BASED_MIPS_JMPADDR16 = 9;

    /// IMAGE_REL_ALPHA_INLINE_REFLONG -> 0x0009
    public const int IMAGE_REL_ALPHA_INLINE_REFLONG = 9;

    /// IMAGE_FILE_LOCAL_SYMS_STRIPPED -> 0x0008
    public const int IMAGE_FILE_LOCAL_SYMS_STRIPPED = 8;

    /// IMAGE_FILE_LARGE_ADDRESS_AWARE -> 0x0020
    public const int IMAGE_FILE_LARGE_ADDRESS_AWARE = 32;

    /// IMAGE_DIRECTORY_ENTRY_SECURITY -> 4
    public const int IMAGE_DIRECTORY_ENTRY_SECURITY = 4;

    /// IMAGE_DIRECTORY_ENTRY_RESOURCE -> 2
    public const int IMAGE_DIRECTORY_ENTRY_RESOURCE = 2;

    /// IMAGE_DEBUG_TYPE_OMAP_FROM_SRC -> 8
    public const int IMAGE_DEBUG_TYPE_OMAP_FROM_SRC = 8;

    /// IMAGE_ARCHIVE_LONGNAMES_MEMBER -> "//              "
    public const string IMAGE_ARCHIVE_LONGNAMES_MEMBER = "//              ";

    /// IMAGE_SYM_CLASS_WEAK_EXTERNAL -> 0x0069
    public const int IMAGE_SYM_CLASS_WEAK_EXTERNAL = 105;

    /// IMAGE_SYM_CLASS_END_OF_STRUCT -> 0x0066
    public const int IMAGE_SYM_CLASS_END_OF_STRUCT = 102;

    /// IMAGE_SEPARATE_DEBUG_MISMATCH -> 0x8000
    public const int IMAGE_SEPARATE_DEBUG_MISMATCH = 32768;

    /// IMAGE_RESOURCE_NAME_IS_STRING -> 0x80000000
    public const int IMAGE_RESOURCE_NAME_IS_STRING = -2147483648;

    /// IMAGE_REL_SH3_STARTOF_SECTION -> 0x000C
    public const int IMAGE_REL_SH3_STARTOF_SECTION = 12;

    /// IMAGE_NT_OPTIONAL_HDR64_MAGIC -> 0x20b
    public const int IMAGE_NT_OPTIONAL_HDR64_MAGIC = 523;

    /// IMAGE_NT_OPTIONAL_HDR32_MAGIC -> 0x10b
    public const int IMAGE_NT_OPTIONAL_HDR32_MAGIC = 267;

    /// IMAGE_FILE_LINE_NUMS_STRIPPED -> 0x0004
    public const int IMAGE_FILE_LINE_NUMS_STRIPPED = 4;

    /// IMAGE_COMDAT_SELECT_SAME_SIZE -> 3
    public const int IMAGE_COMDAT_SELECT_SAME_SIZE = 3;

    /// IMAGE_SYM_CLASS_FAR_EXTERNAL -> 0x0044
    public const int IMAGE_SYM_CLASS_FAR_EXTERNAL = 68;

    /// IMAGE_SYM_CLASS_EXTERNAL_DEF -> 0x0005
    public const int IMAGE_SYM_CLASS_EXTERNAL_DEF = 5;

    /// IMAGE_SIZEOF_BASE_RELOCATION -> 8
    public const int IMAGE_SIZEOF_BASE_RELOCATION = 8;

    /// IMAGE_ROM_OPTIONAL_HDR_MAGIC -> 0x107
    public const int IMAGE_ROM_OPTIONAL_HDR_MAGIC = 263;

    /// IMAGE_REL_SH3_SIZEOF_SECTION -> 0x000D
    public const int IMAGE_REL_SH3_SIZEOF_SECTION = 13;

    /// IMAGE_REL_BASED_MIPS_JMPADDR -> 5
    public const int IMAGE_REL_BASED_MIPS_JMPADDR = 5;

    /// IMAGE_FILE_NET_RUN_FROM_SWAP -> 0x0800
    public const int IMAGE_FILE_NET_RUN_FROM_SWAP = 2048;

    /// IMAGE_FILE_MACHINE_WCEMIPSV2 -> 0x0169
    public const int IMAGE_FILE_MACHINE_WCEMIPSV2 = 361;

    /// IMAGE_FILE_MACHINE_MIPSFPU16 -> 0x0466
    public const int IMAGE_FILE_MACHINE_MIPSFPU16 = 1126;

    /// IMAGE_FILE_MACHINE_POWERPCFP -> 0x01f1
    public const int IMAGE_FILE_MACHINE_POWERPCFP = 497;

    /// IMAGE_FILE_BYTES_REVERSED_LO -> 0x0080
    public const int IMAGE_FILE_BYTES_REVERSED_LO = 128;

    /// IMAGE_FILE_BYTES_REVERSED_HI -> 0x8000
    public const int IMAGE_FILE_BYTES_REVERSED_HI = 32768;

    /// IMAGE_FILE_AGGRESIVE_WS_TRIM -> 0x0010
    public const int IMAGE_FILE_AGGRESIVE_WS_TRIM = 16;

    /// IMAGE_DIRECTORY_ENTRY_IMPORT -> 1
    public const int IMAGE_DIRECTORY_ENTRY_IMPORT = 1;

    /// IMAGE_DEBUG_TYPE_OMAP_TO_SRC -> 7
    public const int IMAGE_DEBUG_TYPE_OMAP_TO_SRC = 7;

    /// IMAGE_DIRECTORY_ENTRY_EXPORT -> 0
    public const int IMAGE_DIRECTORY_ENTRY_EXPORT = 0;

    /// IMAGE_SUBSYSTEM_WINDOWS_GUI -> 2
    public const int IMAGE_SUBSYSTEM_WINDOWS_GUI = 2;

    /// IMAGE_SUBSYSTEM_WINDOWS_CUI -> 3
    public const int IMAGE_SUBSYSTEM_WINDOWS_CUI = 3;

    /// IMAGE_SIZEOF_SECTION_HEADER -> 40
    public const int IMAGE_SIZEOF_SECTION_HEADER = 40;

    /// IMAGE_SCN_NO_DEFER_SPEC_EXC -> 0x00004000
    public const int IMAGE_SCN_NO_DEFER_SPEC_EXC = 16384;

    /// IMAGE_NT_OPTIONAL_HDR_MAGIC -> IMAGE_NT_OPTIONAL_HDR32_MAGIC
    public const int IMAGE_NT_OPTIONAL_HDR_MAGIC = IMAGE_NT_OPTIONAL_HDR32_MAGIC;

    /// IMAGE_FILE_EXECUTABLE_IMAGE -> 0x0002
    public const int IMAGE_FILE_EXECUTABLE_IMAGE = 2;

    /// IMAGE_DIRECTORY_ENTRY_DEBUG -> 6
    public const int IMAGE_DIRECTORY_ENTRY_DEBUG = 6;

    /// IMAGE_DEBUG_TYPE_RESERVED10 -> 10
    public const int IMAGE_DEBUG_TYPE_RESERVED10 = 10;

    /// IMAGE_COMDAT_SELECT_LARGEST -> 6
    public const int IMAGE_COMDAT_SELECT_LARGEST = 6;

    /// IMAGE_ARCHIVE_LINKER_MEMBER -> "/               "
    public const string IMAGE_ARCHIVE_LINKER_MEMBER = "/               ";

    /// IMAGE_SYM_CLASS_STRUCT_TAG -> 0x000A
    public const int IMAGE_SYM_CLASS_STRUCT_TAG = 10;

    /// IMAGE_REL_SH3_PCREL12_WORD -> 0x000B
    public const int IMAGE_REL_SH3_PCREL12_WORD = 11;

    /// IMAGE_REL_SH3_DIRECT8_WORD -> 0x0004
    public const int IMAGE_REL_SH3_DIRECT8_WORD = 4;

    /// IMAGE_REL_SH3_DIRECT8_LONG -> 0x0005
    public const int IMAGE_REL_SH3_DIRECT8_LONG = 5;

    /// IMAGE_REL_SH3_DIRECT4_WORD -> 0x0007
    public const int IMAGE_REL_SH3_DIRECT4_WORD = 7;

    /// IMAGE_REL_SH3_DIRECT4_LONG -> 0x0008
    public const int IMAGE_REL_SH3_DIRECT4_LONG = 8;

    /// IMAGE_REL_BASED_IA64_IMM64 -> 9
    public const int IMAGE_REL_BASED_IA64_IMM64 = 9;

    /// IMAGE_FILE_RELOCS_STRIPPED -> 0x0001
    public const int IMAGE_FILE_RELOCS_STRIPPED = 1;

    /// IMAGE_FILE_MACHINE_UNKNOWN -> 0
    public const int IMAGE_FILE_MACHINE_UNKNOWN = 0;

    /// IMAGE_FILE_MACHINE_TRICORE -> 0x0520
    public const int IMAGE_FILE_MACHINE_TRICORE = 1312;

    /// IMAGE_FILE_MACHINE_POWERPC -> 0x01F0
    public const int IMAGE_FILE_MACHINE_POWERPC = 496;

    /// IMAGE_FILE_MACHINE_MIPSFPU -> 0x0366
    public const int IMAGE_FILE_MACHINE_MIPSFPU = 870;

    /// IMAGE_FILE_MACHINE_ALPHA64 -> 0x0284
    public const int IMAGE_FILE_MACHINE_ALPHA64 = 644;

    /// IMAGE_DEBUG_TYPE_EXCEPTION -> 5
    public const int IMAGE_DEBUG_TYPE_EXCEPTION = 5;

    /// IMAGE_COMDAT_SELECT_NEWEST -> 7
    public const int IMAGE_COMDAT_SELECT_NEWEST = 7;

    /// IMAGE_SYM_CLASS_UNION_TAG -> 0x000C
    public const int IMAGE_SYM_CLASS_UNION_TAG = 12;

    /// IMAGE_SYM_CLASS_CLR_TOKEN -> 0x006B
    public const int IMAGE_SYM_CLASS_CLR_TOKEN = 107;

    /// IMAGE_SYM_CLASS_BIT_FIELD -> 0x0012
    public const int IMAGE_SYM_CLASS_BIT_FIELD = 18;

    /// IMAGE_SYM_CLASS_AUTOMATIC -> 0x0001
    public const int IMAGE_SYM_CLASS_AUTOMATIC = 1;

    /// IMAGE_SUBSYSTEM_POSIX_CUI -> 7
    public const int IMAGE_SUBSYSTEM_POSIX_CUI = 7;

    /// IMAGE_SCN_MEM_DISCARDABLE -> 0x02000000
    public const int IMAGE_SCN_MEM_DISCARDABLE = 33554432;

    /// IMAGE_SCN_LNK_NRELOC_OVFL -> 0x01000000
    public const int IMAGE_SCN_LNK_NRELOC_OVFL = 16777216;

    /// IMAGE_SCN_ALIGN_8192BYTES -> 0x00E00000
    public const int IMAGE_SCN_ALIGN_8192BYTES = 14680064;

    /// IMAGE_SCN_ALIGN_4096BYTES -> 0x00D00000
    public const int IMAGE_SCN_ALIGN_4096BYTES = 13631488;

    /// IMAGE_SCN_ALIGN_2048BYTES -> 0x00C00000
    public const int IMAGE_SCN_ALIGN_2048BYTES = 12582912;

    /// IMAGE_SCN_ALIGN_1024BYTES -> 0x00B00000
    public const int IMAGE_SCN_ALIGN_1024BYTES = 11534336;

    /// IMAGE_REL_SH3_PCREL8_LONG -> 0x000A
    public const int IMAGE_REL_SH3_PCREL8_LONG = 10;

    /// IMAGE_REL_SH3_PCREL8_WORD -> 0x0009
    public const int IMAGE_REL_SH3_PCREL8_WORD = 9;

    /// IMAGE_REL_SH3_GPREL4_LONG -> 0x0011
    public const int IMAGE_REL_SH3_GPREL4_LONG = 17;

    /// IMAGE_REL_SH3_DIRECT32_NB -> 0x0010
    public const int IMAGE_REL_SH3_DIRECT32_NB = 16;

    /// IMAGE_REL_IA64_IMMGPREL64 -> 0x001A
    public const int IMAGE_REL_IA64_IMMGPREL64 = 26;

    /// IMAGE_REL_ALPHA_REFLONGNB -> 0x0010
    public const int IMAGE_REL_ALPHA_REFLONGNB = 16;

    /// IMAGE_FILE_UP_SYSTEM_ONLY -> 0x4000
    public const int IMAGE_FILE_UP_SYSTEM_ONLY = 16384;

    /// IMAGE_FILE_MACHINE_SH3DSP -> 0x01a3
    public const int IMAGE_FILE_MACHINE_SH3DSP = 419;

    /// IMAGE_FILE_MACHINE_R10000 -> 0x0168
    public const int IMAGE_FILE_MACHINE_R10000 = 360;

    /// IMAGE_FILE_MACHINE_MIPS16 -> 0x0266
    public const int IMAGE_FILE_MACHINE_MIPS16 = 614;

    /// IMAGE_FILE_DEBUG_STRIPPED -> 0x0200
    public const int IMAGE_FILE_DEBUG_STRIPPED = 512;

    /// IMAGE_DIRECTORY_ENTRY_TLS -> 9
    public const int IMAGE_DIRECTORY_ENTRY_TLS = 9;

    /// IMAGE_DIRECTORY_ENTRY_IAT -> 12
    public const int IMAGE_DIRECTORY_ENTRY_IAT = 12;

    /// IMAGE_DEBUG_TYPE_CODEVIEW -> 2
    public const int IMAGE_DEBUG_TYPE_CODEVIEW = 2;

    /// IMAGE_SYM_DTYPE_FUNCTION -> 2
    public const int IMAGE_SYM_DTYPE_FUNCTION = 2;

    /// IMAGE_SYM_CLASS_REGISTER -> 0x0004
    public const int IMAGE_SYM_CLASS_REGISTER = 4;

    /// IMAGE_SYM_CLASS_EXTERNAL -> 0x0002
    public const int IMAGE_SYM_CLASS_EXTERNAL = 2;

    /// IMAGE_SYM_CLASS_FUNCTION -> 0x0065
    public const int IMAGE_SYM_CLASS_FUNCTION = 101;

    /// IMAGE_SYM_CLASS_ENUM_TAG -> 0x000F
    public const int IMAGE_SYM_CLASS_ENUM_TAG = 15;

    /// IMAGE_SYM_CLASS_ARGUMENT -> 0x0009
    public const int IMAGE_SYM_CLASS_ARGUMENT = 9;

    /// IMAGE_SIZEOF_FILE_HEADER -> 20
    public const int IMAGE_SIZEOF_FILE_HEADER = 20;

    /// IMAGE_SCN_MEM_NOT_CACHED -> 0x04000000
    public const int IMAGE_SCN_MEM_NOT_CACHED = 67108864;

    /// IMAGE_SCN_ALIGN_512BYTES -> 0x00A00000
    public const int IMAGE_SCN_ALIGN_512BYTES = 10485760;

    /// IMAGE_SCN_ALIGN_256BYTES -> 0x00900000
    public const int IMAGE_SCN_ALIGN_256BYTES = 9437184;

    /// IMAGE_SCN_ALIGN_128BYTES -> 0x00800000
    public const int IMAGE_SCN_ALIGN_128BYTES = 8388608;

    /// IMAGE_REL_MIPS_REFWORDNB -> 0x0022
    public const int IMAGE_REL_MIPS_REFWORDNB = 34;

    /// IMAGE_REL_MIPS_JMPADDR16 -> 0x0010
    public const int IMAGE_REL_MIPS_JMPADDR16 = 16;

    /// IMAGE_REL_IA64_SECREL64I -> 0x000D
    public const int IMAGE_REL_IA64_SECREL64I = 13;

    /// IMAGE_REL_BASED_ABSOLUTE -> 0
    public const int IMAGE_REL_BASED_ABSOLUTE = 0;

    /// IMAGE_REL_AMD64_ADDR32NB -> 0x0003
    public const int IMAGE_REL_AMD64_ADDR32NB = 3;

    /// IMAGE_REL_AMD64_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_AMD64_ABSOLUTE = 0;

    /// IMAGE_REL_ALPHA_SECRELLO -> 0x0011
    public const int IMAGE_REL_ALPHA_SECRELLO = 17;

    /// IMAGE_REL_ALPHA_SECRELHI -> 0x0012
    public const int IMAGE_REL_ALPHA_SECRELHI = 18;

    /// IMAGE_REL_ALPHA_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_ALPHA_ABSOLUTE = 0;

    /// IMAGE_FILE_MACHINE_THUMB -> 0x01c2
    public const int IMAGE_FILE_MACHINE_THUMB = 450;

    /// IMAGE_FILE_MACHINE_R4000 -> 0x0166
    public const int IMAGE_FILE_MACHINE_R4000 = 358;

    /// IMAGE_FILE_MACHINE_R3000 -> 0x0162
    public const int IMAGE_FILE_MACHINE_R3000 = 354;

    /// IMAGE_FILE_MACHINE_AXP64 -> IMAGE_FILE_MACHINE_ALPHA64
    public const int IMAGE_FILE_MACHINE_AXP64 = IMAGE_FILE_MACHINE_ALPHA64;

    /// IMAGE_FILE_MACHINE_AMD64 -> 0x8664
    public const int IMAGE_FILE_MACHINE_AMD64 = 34404;

    /// IMAGE_FILE_MACHINE_ALPHA -> 0x0184
    public const int IMAGE_FILE_MACHINE_ALPHA = 388;

    /// IMAGE_FILE_32BIT_MACHINE -> 0x0100
    public const int IMAGE_FILE_32BIT_MACHINE = 256;

    /// IMAGE_DEBUG_TYPE_BORLAND -> 9
    public const int IMAGE_DEBUG_TYPE_BORLAND = 9;

    /// IMAGE_DEBUG_TYPE_UNKNOWN -> 0
    public const int IMAGE_DEBUG_TYPE_UNKNOWN = 0;

    /// IMAGE_DEBUG_MISC_EXENAME -> 1
    public const int IMAGE_DEBUG_MISC_EXENAME = 1;

    /// IMAGE_ARCHIVE_START_SIZE -> 8
    public const int IMAGE_ARCHIVE_START_SIZE = 8;

    /// IMAGE_SYM_DTYPE_POINTER -> 1
    public const int IMAGE_SYM_DTYPE_POINTER = 1;

    /// IMAGE_SYM_CLASS_SECTION -> 0x0068
    public const int IMAGE_SYM_CLASS_SECTION = 104;

    /// IMAGE_SUBSYSTEM_UNKNOWN -> 0
    public const int IMAGE_SUBSYSTEM_UNKNOWN = 0;

    /// IMAGE_SUBSYSTEM_OS2_CUI -> 5
    public const int IMAGE_SUBSYSTEM_OS2_CUI = 5;

    /// IMAGE_SUBSYSTEM_EFI_ROM -> 13
    public const int IMAGE_SUBSYSTEM_EFI_ROM = 13;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_SNAP_BY_ORDINAL32 -> "(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG32) != 0)"
    public const string IMAGE_SNAP_BY_ORDINAL32 = "(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG32) != 0)";

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_SNAP_BY_ORDINAL64 -> "(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG64) != 0)"
    public const string IMAGE_SNAP_BY_ORDINAL64 = "(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG64) != 0)";

    /// IMAGE_SIZEOF_SHORT_NAME -> 8
    public const int IMAGE_SIZEOF_SHORT_NAME = 8;

    /// IMAGE_SIZEOF_RELOCATION -> 10
    public const int IMAGE_SIZEOF_RELOCATION = 10;

    /// IMAGE_SIZEOF_LINENUMBER -> 6
    public const int IMAGE_SIZEOF_LINENUMBER = 6;

    /// IMAGE_SIZEOF_AUX_SYMBOL -> 18
    public const int IMAGE_SIZEOF_AUX_SYMBOL = 18;

    /// IMAGE_SCN_MEM_PURGEABLE -> 0x00020000
    public const int IMAGE_SCN_MEM_PURGEABLE = 131072;

    /// IMAGE_SCN_MEM_NOT_PAGED -> 0x08000000
    public const int IMAGE_SCN_MEM_NOT_PAGED = 134217728;

    /// IMAGE_SCN_ALIGN_64BYTES -> 0x00700000
    public const int IMAGE_SCN_ALIGN_64BYTES = 7340032;

    /// IMAGE_SCN_ALIGN_32BYTES -> 0x00600000
    public const int IMAGE_SCN_ALIGN_32BYTES = 6291456;

    /// IMAGE_SCN_ALIGN_16BYTES -> 0x00500000
    public const int IMAGE_SCN_ALIGN_16BYTES = 5242880;

    /// IMAGE_REL_MIPS_SECRELLO -> 0x000C
    public const int IMAGE_REL_MIPS_SECRELLO = 12;

    /// IMAGE_REL_MIPS_SECRELHI -> 0x000D
    public const int IMAGE_REL_MIPS_SECRELHI = 13;

    /// IMAGE_REL_MIPS_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_MIPS_ABSOLUTE = 0;

    /// IMAGE_REL_M32R_SECREL32 -> 0x000D
    public const int IMAGE_REL_M32R_SECREL32 = 13;

    /// IMAGE_REL_M32R_ADDR32NB -> 0x0002
    public const int IMAGE_REL_M32R_ADDR32NB = 2;

    /// IMAGE_REL_M32R_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_M32R_ABSOLUTE = 0;

    /// IMAGE_REL_IA64_SECREL32 -> 0x000E
    public const int IMAGE_REL_IA64_SECREL32 = 14;

    /// IMAGE_REL_IA64_SECREL22 -> 0x000C
    public const int IMAGE_REL_IA64_SECREL22 = 12;

    /// IMAGE_REL_IA64_PCREL60X -> 0x0015
    public const int IMAGE_REL_IA64_PCREL60X = 21;

    /// IMAGE_REL_IA64_PCREL60M -> 0x0019
    public const int IMAGE_REL_IA64_PCREL60M = 25;

    /// IMAGE_REL_IA64_PCREL60I -> 0x0018
    public const int IMAGE_REL_IA64_PCREL60I = 24;

    /// IMAGE_REL_IA64_PCREL60F -> 0x0017
    public const int IMAGE_REL_IA64_PCREL60F = 23;

    /// IMAGE_REL_IA64_PCREL60B -> 0x0016
    public const int IMAGE_REL_IA64_PCREL60B = 22;

    /// IMAGE_REL_IA64_PCREL21F -> 0x0008
    public const int IMAGE_REL_IA64_PCREL21F = 8;

    /// IMAGE_REL_IA64_PCREL21M -> 0x0007
    public const int IMAGE_REL_IA64_PCREL21M = 7;

    /// IMAGE_REL_IA64_PCREL21B -> 0x0006
    public const int IMAGE_REL_IA64_PCREL21B = 6;

    /// IMAGE_REL_IA64_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_IA64_ABSOLUTE = 0;

    /// IMAGE_REL_I386_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_I386_ABSOLUTE = 0;

    /// IMAGE_REL_BASED_HIGHLOW -> 3
    public const int IMAGE_REL_BASED_HIGHLOW = 3;

    /// IMAGE_REL_BASED_HIGHADJ -> 4
    public const int IMAGE_REL_BASED_HIGHADJ = 4;

    /// IMAGE_REL_AMD64_SSPAN32 -> 0x0010
    public const int IMAGE_REL_AMD64_SSPAN32 = 16;

    /// IMAGE_REL_AMD64_SECTION -> 0x000A
    public const int IMAGE_REL_AMD64_SECTION = 10;

    /// IMAGE_REL_AMD64_SECREL7 -> 0x000C
    public const int IMAGE_REL_AMD64_SECREL7 = 12;

    /// IMAGE_REL_AMD64_REL32_5 -> 0x0009
    public const int IMAGE_REL_AMD64_REL32_5 = 9;

    /// IMAGE_REL_AMD64_REL32_4 -> 0x0008
    public const int IMAGE_REL_AMD64_REL32_4 = 8;

    /// IMAGE_REL_AMD64_REL32_3 -> 0x0007
    public const int IMAGE_REL_AMD64_REL32_3 = 7;

    /// IMAGE_REL_AMD64_REL32_2 -> 0x0006
    public const int IMAGE_REL_AMD64_REL32_2 = 6;

    /// IMAGE_REL_AMD64_REL32_1 -> 0x0005
    public const int IMAGE_REL_AMD64_REL32_1 = 5;

    /// IMAGE_REL_ALPHA_SECTION -> 0x000E
    public const int IMAGE_REL_ALPHA_SECTION = 14;

    /// IMAGE_REL_ALPHA_REFQUAD -> 0x0002
    public const int IMAGE_REL_ALPHA_REFQUAD = 2;

    /// IMAGE_REL_ALPHA_LITERAL -> 0x0004
    public const int IMAGE_REL_ALPHA_LITERAL = 4;

    /// IMAGE_REL_ALPHA_REFLONG -> 0x0001
    public const int IMAGE_REL_ALPHA_REFLONG = 1;

    /// IMAGE_REL_ALPHA_GPRELLO -> 0x0016
    public const int IMAGE_REL_ALPHA_GPRELLO = 22;

    /// IMAGE_REL_ALPHA_GPRELHI -> 0x0017
    public const int IMAGE_REL_ALPHA_GPRELHI = 23;

    /// IMAGE_REL_ALPHA_GPREL32 -> 0x0003
    public const int IMAGE_REL_ALPHA_GPREL32 = 3;

    /// IMAGE_FILE_MACHINE_SH3E -> 0x01a4
    public const int IMAGE_FILE_MACHINE_SH3E = 420;

    /// IMAGE_FILE_MACHINE_M32R -> 0x9041
    public const int IMAGE_FILE_MACHINE_M32R = 36929;

    /// IMAGE_FILE_MACHINE_IA64 -> 0x0200
    public const int IMAGE_FILE_MACHINE_IA64 = 512;

    /// IMAGE_FILE_MACHINE_I386 -> 0x014c
    public const int IMAGE_FILE_MACHINE_I386 = 332;

    /// IMAGE_FILE_MACHINE_AM33 -> 0x01d3
    public const int IMAGE_FILE_MACHINE_AM33 = 467;

    /// IMAGE_COMDAT_SELECT_ANY -> 2
    public const int IMAGE_COMDAT_SELECT_ANY = 2;

    /// IMAGE_SYM_CLASS_STATIC -> 0x0003
    public const int IMAGE_SYM_CLASS_STATIC = 3;

    /// IMAGE_SUBSYSTEM_NATIVE -> 1
    public const int IMAGE_SUBSYSTEM_NATIVE = 1;

    /// IMAGE_SCN_ALIGN_8BYTES -> 0x00400000
    public const int IMAGE_SCN_ALIGN_8BYTES = 4194304;

    /// IMAGE_SCN_ALIGN_4BYTES -> 0x00300000
    public const int IMAGE_SCN_ALIGN_4BYTES = 3145728;

    /// IMAGE_SCN_ALIGN_2BYTES -> 0x00200000
    public const int IMAGE_SCN_ALIGN_2BYTES = 2097152;

    /// IMAGE_SCN_ALIGN_1BYTES -> 0x00100000
    public const int IMAGE_SCN_ALIGN_1BYTES = 1048576;

    /// IMAGE_REL_SH3_DIRECT32 -> 0x0002
    public const int IMAGE_REL_SH3_DIRECT32 = 2;

    /// IMAGE_REL_SH3_DIRECT16 -> 0x0001
    public const int IMAGE_REL_SH3_DIRECT16 = 1;

    /// IMAGE_REL_SH3_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_SH3_ABSOLUTE = 0;

    /// IMAGE_REL_PPC_TYPEMASK -> 0x00FF
    public const int IMAGE_REL_PPC_TYPEMASK = 255;

    /// IMAGE_REL_PPC_TOCREL16 -> 0x0008
    public const int IMAGE_REL_PPC_TOCREL16 = 8;

    /// IMAGE_REL_PPC_TOCREL14 -> 0x0009
    public const int IMAGE_REL_PPC_TOCREL14 = 9;

    /// IMAGE_REL_PPC_SECRELLO -> 0x0013
    public const int IMAGE_REL_PPC_SECRELLO = 19;

    /// IMAGE_REL_PPC_SECRELHI -> 0x0014
    public const int IMAGE_REL_PPC_SECRELHI = 20;

    /// IMAGE_REL_PPC_SECREL16 -> 0x000F
    public const int IMAGE_REL_PPC_SECREL16 = 15;

    /// IMAGE_REL_PPC_BRNTAKEN -> 0x0400
    public const int IMAGE_REL_PPC_BRNTAKEN = 1024;

    /// IMAGE_REL_PPC_ADDR32NB -> 0x000A
    public const int IMAGE_REL_PPC_ADDR32NB = 10;

    /// IMAGE_REL_PPC_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_PPC_ABSOLUTE = 0;

    /// IMAGE_REL_MIPS_SECTION -> 0x000A
    public const int IMAGE_REL_MIPS_SECTION = 10;

    /// IMAGE_REL_MIPS_REFWORD -> 0x0002
    public const int IMAGE_REL_MIPS_REFWORD = 2;

    /// IMAGE_REL_MIPS_REFHALF -> 0x0001
    public const int IMAGE_REL_MIPS_REFHALF = 1;

    /// IMAGE_REL_MIPS_LITERAL -> 0x0007
    public const int IMAGE_REL_MIPS_LITERAL = 7;

    /// IMAGE_REL_MIPS_JMPADDR -> 0x0003
    public const int IMAGE_REL_MIPS_JMPADDR = 3;

    /// IMAGE_REL_M32R_SECTION -> 0x000C
    public const int IMAGE_REL_M32R_SECTION = 12;

    /// IMAGE_REL_M32R_REFHALF -> 0x0008
    public const int IMAGE_REL_M32R_REFHALF = 8;

    /// IMAGE_REL_M32R_PCREL24 -> 0x0005
    public const int IMAGE_REL_M32R_PCREL24 = 5;

    /// IMAGE_REL_M32R_PCREL16 -> 0x0006
    public const int IMAGE_REL_M32R_PCREL16 = 6;

    /// IMAGE_REL_M32R_GPREL16 -> 0x0004
    public const int IMAGE_REL_M32R_GPREL16 = 4;

    /// IMAGE_REL_IA64_SECTION -> 0x000B
    public const int IMAGE_REL_IA64_SECTION = 11;

    /// IMAGE_REL_IA64_GPREL32 -> 0x001C
    public const int IMAGE_REL_IA64_GPREL32 = 28;

    /// IMAGE_REL_IA64_LTOFF22 -> 0x000A
    public const int IMAGE_REL_IA64_LTOFF22 = 10;

    /// IMAGE_REL_IA64_GPREL22 -> 0x0009
    public const int IMAGE_REL_IA64_GPREL22 = 9;

    /// IMAGE_REL_IA64_DIR32NB -> 0x0010
    public const int IMAGE_REL_IA64_DIR32NB = 16;

    /// IMAGE_REL_I386_SECTION -> 0x000A
    public const int IMAGE_REL_I386_SECTION = 10;

    /// IMAGE_REL_I386_SECREL7 -> 0x000D
    public const int IMAGE_REL_I386_SECREL7 = 13;

    /// IMAGE_REL_I386_DIR32NB -> 0x0007
    public const int IMAGE_REL_I386_DIR32NB = 7;

    /// IMAGE_REL_CEF_ADDR32NB -> 0x0003
    public const int IMAGE_REL_CEF_ADDR32NB = 3;

    /// IMAGE_REL_CEF_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_CEF_ABSOLUTE = 0;

    /// IMAGE_REL_CEE_ADDR32NB -> 0x0003
    public const int IMAGE_REL_CEE_ADDR32NB = 3;

    /// IMAGE_REL_CEE_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_CEE_ABSOLUTE = 0;

    /// IMAGE_REL_ARM_BRANCH24 -> 0x0003
    public const int IMAGE_REL_ARM_BRANCH24 = 3;

    /// IMAGE_REL_ARM_BRANCH11 -> 0x0004
    public const int IMAGE_REL_ARM_BRANCH11 = 4;

    /// IMAGE_REL_ARM_ADDR32NB -> 0x0002
    public const int IMAGE_REL_ARM_ADDR32NB = 2;

    /// IMAGE_REL_ARM_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_ARM_ABSOLUTE = 0;

    /// IMAGE_REL_AMD64_SREL32 -> 0x000E
    public const int IMAGE_REL_AMD64_SREL32 = 14;

    /// IMAGE_REL_AMD64_SECREL -> 0x000B
    public const int IMAGE_REL_AMD64_SECREL = 11;

    /// IMAGE_REL_AMD64_ADDR64 -> 0x0001
    public const int IMAGE_REL_AMD64_ADDR64 = 1;

    /// IMAGE_REL_AMD64_ADDR32 -> 0x0002
    public const int IMAGE_REL_AMD64_ADDR32 = 2;

    /// IMAGE_REL_ALPHA_SECREL -> 0x000F
    public const int IMAGE_REL_ALPHA_SECREL = 15;

    /// IMAGE_REL_ALPHA_LITUSE -> 0x0005
    public const int IMAGE_REL_ALPHA_LITUSE = 5;

    /// IMAGE_REL_ALPHA_GPDISP -> 0x0006
    public const int IMAGE_REL_ALPHA_GPDISP = 6;

    /// IMAGE_REL_ALPHA_BRADDR -> 0x0007
    public const int IMAGE_REL_ALPHA_BRADDR = 7;

    /// IMAGE_OS2_SIGNATURE_LE -> 0x454C
    public const int IMAGE_OS2_SIGNATURE_LE = 17740;

    /// IMAGE_FILE_MACHINE_SH5 -> 0x01a8
    public const int IMAGE_FILE_MACHINE_SH5 = 424;

    /// IMAGE_FILE_MACHINE_SH4 -> 0x01a6
    public const int IMAGE_FILE_MACHINE_SH4 = 422;

    /// IMAGE_FILE_MACHINE_EBC -> 0x0EBC
    public const int IMAGE_FILE_MACHINE_EBC = 3772;

    /// IMAGE_FILE_MACHINE_SH3 -> 0x01a2
    public const int IMAGE_FILE_MACHINE_SH3 = 418;

    /// IMAGE_FILE_MACHINE_CEF -> 0x0CEF
    public const int IMAGE_FILE_MACHINE_CEF = 3311;

    /// IMAGE_FILE_MACHINE_CEE -> 0xC0EE
    public const int IMAGE_FILE_MACHINE_CEE = 49390;

    /// IMAGE_FILE_MACHINE_ARM -> 0x01c0
    public const int IMAGE_FILE_MACHINE_ARM = 448;

    /// IMAGE_DEBUG_TYPE_FIXUP -> 6
    public const int IMAGE_DEBUG_TYPE_FIXUP = 6;

    /// IMAGE_DEBUG_TYPE_CLSID -> 11
    public const int IMAGE_DEBUG_TYPE_CLSID = 11;

    /// IMAGE_SYM_TYPE_STRUCT -> 0x0008
    public const int IMAGE_SYM_TYPE_STRUCT = 8;

    /// IMAGE_SYM_TYPE_DOUBLE -> 0x0007
    public const int IMAGE_SYM_TYPE_DOUBLE = 7;

    /// IMAGE_SYM_SECTION_MAX -> 0xFEFF
    public const int IMAGE_SYM_SECTION_MAX = 65279;

    /// IMAGE_SYM_DTYPE_ARRAY -> 3
    public const int IMAGE_SYM_DTYPE_ARRAY = 3;

    /// IMAGE_SYM_CLASS_LABEL -> 0x0006
    public const int IMAGE_SYM_CLASS_LABEL = 6;

    /// IMAGE_SYM_CLASS_BLOCK -> 0x0064
    public const int IMAGE_SYM_CLASS_BLOCK = 100;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_SNAP_BY_ORDINAL -> "(Ordinal) IMAGE_SNAP_BY_ORDINAL32(Ordinal)"
    public const string IMAGE_SNAP_BY_ORDINAL = "(Ordinal) IMAGE_SNAP_BY_ORDINAL32(Ordinal)";

    /// IMAGE_SCN_TYPE_NO_PAD -> 0x00000008
    public const int IMAGE_SCN_TYPE_NO_PAD = 8;

    /// IMAGE_SCN_MEM_PRELOAD -> 0x00080000
    public const int IMAGE_SCN_MEM_PRELOAD = 524288;

    /// IMAGE_SCN_SCALE_INDEX -> 0x00000001
    public const int IMAGE_SCN_SCALE_INDEX = 1;

    /// IMAGE_SCN_MEM_FARDATA -> 0x00008000
    public const int IMAGE_SCN_MEM_FARDATA = 32768;

    /// IMAGE_SCN_MEM_EXECUTE -> 0x20000000
    public const int IMAGE_SCN_MEM_EXECUTE = 536870912;

    /// IMAGE_REL_SH3_SECTION -> 0x000E
    public const int IMAGE_REL_SH3_SECTION = 14;

    /// IMAGE_REL_SH3_DIRECT8 -> 0x0003
    public const int IMAGE_REL_SH3_DIRECT8 = 3;

    /// IMAGE_REL_SH3_DIRECT4 -> 0x0006
    public const int IMAGE_REL_SH3_DIRECT4 = 6;

    /// IMAGE_REL_PPC_TOCDEFN -> 0x0800
    public const int IMAGE_REL_PPC_TOCDEFN = 2048;

    /// IMAGE_REL_PPC_SECTION -> 0x000C
    public const int IMAGE_REL_PPC_SECTION = 12;

    /// IMAGE_REL_PPC_BRTAKEN -> 0x0200
    public const int IMAGE_REL_PPC_BRTAKEN = 512;

    /// IMAGE_REL_MIPS_SECREL -> 0x000B
    public const int IMAGE_REL_MIPS_SECREL = 11;

    /// IMAGE_REL_M32R_PCREL8 -> 0x0007
    public const int IMAGE_REL_M32R_PCREL8 = 7;

    /// IMAGE_REL_M32R_ADDR32 -> 0x0001
    public const int IMAGE_REL_M32R_ADDR32 = 1;

    /// IMAGE_REL_M32R_ADDR24 -> 0x0003
    public const int IMAGE_REL_M32R_ADDR24 = 3;

    /// IMAGE_REL_IA64_UREL32 -> 0x0014
    public const int IMAGE_REL_IA64_UREL32 = 20;

    /// IMAGE_REL_IA64_SREL32 -> 0x0013
    public const int IMAGE_REL_IA64_SREL32 = 19;

    /// IMAGE_REL_IA64_SREL22 -> 0x0012
    public const int IMAGE_REL_IA64_SREL22 = 18;

    /// IMAGE_REL_IA64_SREL14 -> 0x0011
    public const int IMAGE_REL_IA64_SREL14 = 17;

    /// IMAGE_REL_IA64_ADDEND -> 0x001F
    public const int IMAGE_REL_IA64_ADDEND = 31;

    /// IMAGE_REL_I386_SECREL -> 0x000B
    public const int IMAGE_REL_I386_SECREL = 11;

    /// IMAGE_REL_CEF_SECTION -> 0x0004
    public const int IMAGE_REL_CEF_SECTION = 4;

    /// IMAGE_REL_CEE_SECTION -> 0x0004
    public const int IMAGE_REL_CEE_SECTION = 4;

    /// IMAGE_REL_BASED_DIR64 -> 10
    public const int IMAGE_REL_BASED_DIR64 = 10;

    /// IMAGE_REL_ARM_SECTION -> 0x000E
    public const int IMAGE_REL_ARM_SECTION = 14;

    /// IMAGE_REL_ARM_GPREL12 -> 0x0006
    public const int IMAGE_REL_ARM_GPREL12 = 6;

    /// IMAGE_REL_AM_FUNCINFO -> 0x0004
    public const int IMAGE_REL_AM_FUNCINFO = 4;

    /// IMAGE_REL_AM_ADDR32NB -> 0x0002
    public const int IMAGE_REL_AM_ADDR32NB = 2;

    /// IMAGE_REL_AMD64_TOKEN -> 0x000D
    public const int IMAGE_REL_AMD64_TOKEN = 13;

    /// IMAGE_REL_AM_ABSOLUTE -> 0x0000
    public const int IMAGE_REL_AM_ABSOLUTE = 0;

    /// IMAGE_REL_AMD64_REL32 -> 0x0004
    public const int IMAGE_REL_AMD64_REL32 = 4;

    /// IMAGE_REL_ALPHA_REFQ2 -> 0x0014
    public const int IMAGE_REL_ALPHA_REFQ2 = 20;

    /// IMAGE_REL_ALPHA_REFQ3 -> 0x0013
    public const int IMAGE_REL_ALPHA_REFQ3 = 19;

    /// IMAGE_REL_ALPHA_REFQ1 -> 0x0015
    public const int IMAGE_REL_ALPHA_REFQ1 = 21;

    /// IMAGE_REL_ALPHA_REFLO -> 0x000B
    public const int IMAGE_REL_ALPHA_REFLO = 11;

    /// IMAGE_REL_ALPHA_REFHI -> 0x000A
    public const int IMAGE_REL_ALPHA_REFHI = 10;

    /// IMAGE_REL_ALPHA_MATCH -> 0x000D
    public const int IMAGE_REL_ALPHA_MATCH = 13;

    /// IMAGE_DEBUG_TYPE_MISC -> 4
    public const int IMAGE_DEBUG_TYPE_MISC = 4;

    /// IMAGE_DEBUG_TYPE_COFF -> 1
    public const int IMAGE_DEBUG_TYPE_COFF = 1;

    /// IMAGE_SYM_TYPE_SHORT -> 0x0003
    public const int IMAGE_SYM_TYPE_SHORT = 3;

    /// IMAGE_SYM_TYPE_UNION -> 0x0009
    public const int IMAGE_SYM_TYPE_UNION = 9;

    /// IMAGE_SYM_TYPE_PCODE -> 0x8000
    public const int IMAGE_SYM_TYPE_PCODE = 32768;

    /// IMAGE_SYM_TYPE_DWORD -> 0x000F
    public const int IMAGE_SYM_TYPE_DWORD = 15;

    /// IMAGE_SYM_TYPE_FLOAT -> 0x0006
    public const int IMAGE_SYM_TYPE_FLOAT = 6;

    /// IMAGE_SYM_DTYPE_NULL -> 0
    public const int IMAGE_SYM_DTYPE_NULL = 0;

    /// IMAGE_SYM_CLASS_NULL -> 0x0000
    public const int IMAGE_SYM_CLASS_NULL = 0;

    /// IMAGE_SYM_CLASS_FILE -> 0x0067
    public const int IMAGE_SYM_CLASS_FILE = 103;

    /// IMAGE_SUBSYSTEM_XBOX -> 14
    public const int IMAGE_SUBSYSTEM_XBOX = 14;

    /// IMAGE_SCN_MEM_SHARED -> 0x10000000
    public const int IMAGE_SCN_MEM_SHARED = 268435456;

    /// IMAGE_SCN_MEM_LOCKED -> 0x00040000
    public const int IMAGE_SCN_MEM_LOCKED = 262144;

    /// IMAGE_SCN_LNK_REMOVE -> 0x00000800
    public const int IMAGE_SCN_LNK_REMOVE = 2048;

    /// IMAGE_SCN_LNK_COMDAT -> 0x00001000
    public const int IMAGE_SCN_LNK_COMDAT = 4096;

    /// IMAGE_SCN_ALIGN_MASK -> 0x00F00000
    public const int IMAGE_SCN_ALIGN_MASK = 15728640;

    /// IMAGE_REL_SH3_SECREL -> 0x000F
    public const int IMAGE_REL_SH3_SECREL = 15;

    /// IMAGE_REL_PPC_SECREL -> 0x000B
    public const int IMAGE_REL_PPC_SECREL = 11;

    /// IMAGE_REL_PPC_IMGLUE -> 0x000E
    public const int IMAGE_REL_PPC_IMGLUE = 14;

    /// IMAGE_REL_PPC_IFGLUE -> 0x000D
    public const int IMAGE_REL_PPC_IFGLUE = 13;

    /// IMAGE_REL_PPC_ADDR64 -> 0x0001
    public const int IMAGE_REL_PPC_ADDR64 = 1;

    /// IMAGE_REL_PPC_ADDR32 -> 0x0002
    public const int IMAGE_REL_PPC_ADDR32 = 2;

    /// IMAGE_REL_PPC_ADDR24 -> 0x0003
    public const int IMAGE_REL_PPC_ADDR24 = 3;

    /// IMAGE_REL_PPC_ADDR16 -> 0x0004
    public const int IMAGE_REL_PPC_ADDR16 = 4;

    /// IMAGE_REL_PPC_ADDR14 -> 0x0005
    public const int IMAGE_REL_PPC_ADDR14 = 5;

    /// IMAGE_REL_MIPS_TOKEN -> 0x000E
    public const int IMAGE_REL_MIPS_TOKEN = 14;

    /// IMAGE_REL_MIPS_REFLO -> 0x0005
    public const int IMAGE_REL_MIPS_REFLO = 5;

    /// IMAGE_REL_MIPS_REFHI -> 0x0004
    public const int IMAGE_REL_MIPS_REFHI = 4;

    /// IMAGE_REL_MIPS_GPREL -> 0x0006
    public const int IMAGE_REL_MIPS_GPREL = 6;

    /// IMAGE_REL_M32R_TOKEN -> 0x000E
    public const int IMAGE_REL_M32R_TOKEN = 14;

    /// IMAGE_REL_M32R_REFLO -> 0x000A
    public const int IMAGE_REL_M32R_REFLO = 10;

    /// IMAGE_REL_M32R_REFHI -> 0x0009
    public const int IMAGE_REL_M32R_REFHI = 9;

    /// IMAGE_REL_IA64_TOKEN -> 0x001B
    public const int IMAGE_REL_IA64_TOKEN = 27;

    /// IMAGE_REL_IA64_IMM64 -> 0x0003
    public const int IMAGE_REL_IA64_IMM64 = 3;

    /// IMAGE_REL_IA64_IMM22 -> 0x0002
    public const int IMAGE_REL_IA64_IMM22 = 2;

    /// IMAGE_REL_IA64_IMM14 -> 0x0001
    public const int IMAGE_REL_IA64_IMM14 = 1;

    /// IMAGE_REL_IA64_DIR64 -> 0x0005
    public const int IMAGE_REL_IA64_DIR64 = 5;

    /// IMAGE_REL_IA64_DIR32 -> 0x0004
    public const int IMAGE_REL_IA64_DIR32 = 4;

    /// IMAGE_REL_I386_TOKEN -> 0x000C
    public const int IMAGE_REL_I386_TOKEN = 12;

    /// IMAGE_REL_I386_SEG12 -> 0x0009
    public const int IMAGE_REL_I386_SEG12 = 9;

    /// IMAGE_REL_I386_REL32 -> 0x0014
    public const int IMAGE_REL_I386_REL32 = 20;

    /// IMAGE_REL_I386_REL16 -> 0x0002
    public const int IMAGE_REL_I386_REL16 = 2;

    /// IMAGE_REL_I386_DIR32 -> 0x0006
    public const int IMAGE_REL_I386_DIR32 = 6;

    /// IMAGE_REL_I386_DIR16 -> 0x0001
    public const int IMAGE_REL_I386_DIR16 = 1;

    /// IMAGE_REL_CEF_SECREL -> 0x0005
    public const int IMAGE_REL_CEF_SECREL = 5;

    /// IMAGE_REL_CEF_ADDR64 -> 0x0002
    public const int IMAGE_REL_CEF_ADDR64 = 2;

    /// IMAGE_REL_CEF_ADDR32 -> 0x0001
    public const int IMAGE_REL_CEF_ADDR32 = 1;

    /// IMAGE_REL_CEE_SECREL -> 0x0005
    public const int IMAGE_REL_CEE_SECREL = 5;

    /// IMAGE_REL_CEE_ADDR64 -> 0x0002
    public const int IMAGE_REL_CEE_ADDR64 = 2;

    /// IMAGE_REL_BASED_HIGH -> 1
    public const int IMAGE_REL_BASED_HIGH = 1;

    /// IMAGE_REL_CEE_ADDR32 -> 0x0001
    public const int IMAGE_REL_CEE_ADDR32 = 1;

    /// IMAGE_REL_ARM_SECREL -> 0x000F
    public const int IMAGE_REL_ARM_SECREL = 15;

    /// IMAGE_REL_ARM_GPREL7 -> 0x0007
    public const int IMAGE_REL_ARM_GPREL7 = 7;

    /// IMAGE_REL_ARM_ADDR32 -> 0x0001
    public const int IMAGE_REL_ARM_ADDR32 = 1;

    /// IMAGE_REL_AM_SECTION -> 0x0008
    public const int IMAGE_REL_AM_SECTION = 8;

    /// IMAGE_REL_AM_REL32_2 -> 0x0006
    public const int IMAGE_REL_AM_REL32_2 = 6;

    /// IMAGE_REL_AM_REL32_1 -> 0x0005
    public const int IMAGE_REL_AM_REL32_1 = 5;

    /// IMAGE_REL_AMD64_PAIR -> 0x000F
    public const int IMAGE_REL_AMD64_PAIR = 15;

    /// IMAGE_REL_ALPHA_PAIR -> 0x000C
    public const int IMAGE_REL_ALPHA_PAIR = 12;

    /// IMAGE_REL_ALPHA_HINT -> 0x0008
    public const int IMAGE_REL_ALPHA_HINT = 8;

    /// IMAGE_ORDINAL_FLAG64 -> 0x8000000000000000
    public const long IMAGE_ORDINAL_FLAG64 = -9223372036854775808;

    /// IMAGE_ORDINAL_FLAG32 -> 0x80000000
    public const int IMAGE_ORDINAL_FLAG32 = -2147483648;

    /// IMAGE_DEBUG_TYPE_FPO -> 3
    public const int IMAGE_DEBUG_TYPE_FPO = 3;

    /// IMAGE_VXD_SIGNATURE -> 0x454C
    public const int IMAGE_VXD_SIGNATURE = 17740;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_SYM_UNDEFINED -> "(SHORT) 0"
    public const string IMAGE_SYM_UNDEFINED = "(SHORT) 0";

    /// IMAGE_SYM_TYPE_WORD -> 0x000D
    public const int IMAGE_SYM_TYPE_WORD = 13;

    /// IMAGE_SYM_TYPE_VOID -> 0x0001
    public const int IMAGE_SYM_TYPE_VOID = 1;

    /// IMAGE_SYM_TYPE_UINT -> 0x000E
    public const int IMAGE_SYM_TYPE_UINT = 14;

    /// IMAGE_SYM_TYPE_NULL -> 0x0000
    public const int IMAGE_SYM_TYPE_NULL = 0;

    /// IMAGE_SYM_TYPE_LONG -> 0x0005
    public const int IMAGE_SYM_TYPE_LONG = 5;

    /// IMAGE_SYM_TYPE_ENUM -> 0x000A
    public const int IMAGE_SYM_TYPE_ENUM = 10;

    /// IMAGE_SYM_TYPE_CHAR -> 0x0002
    public const int IMAGE_SYM_TYPE_CHAR = 2;

    /// IMAGE_SYM_TYPE_BYTE -> 0x000C
    public const int IMAGE_SYM_TYPE_BYTE = 12;

    /// IMAGE_SIZEOF_SYMBOL -> 18
    public const int IMAGE_SIZEOF_SYMBOL = 18;

    /// IMAGE_SCN_MEM_16BIT -> 0x00020000
    public const int IMAGE_SCN_MEM_16BIT = 131072;

    /// IMAGE_SCN_MEM_WRITE -> 0x80000000
    public const int IMAGE_SCN_MEM_WRITE = -2147483648;

    /// IMAGE_REL_SH3_TOKEN -> 0x0012
    public const int IMAGE_REL_SH3_TOKEN = 18;

    /// IMAGE_SCN_LNK_OTHER -> 0x00000100
    public const int IMAGE_SCN_LNK_OTHER = 256;

    /// IMAGE_REL_PPC_TOKEN -> 0x0016
    public const int IMAGE_REL_PPC_TOKEN = 22;

    /// IMAGE_REL_PPC_REL24 -> 0x0006
    public const int IMAGE_REL_PPC_REL24 = 6;

    /// IMAGE_REL_PPC_REL14 -> 0x0007
    public const int IMAGE_REL_PPC_REL14 = 7;

    /// IMAGE_REL_PPC_REFLO -> 0x0011
    public const int IMAGE_REL_PPC_REFLO = 17;

    /// IMAGE_REL_PPC_REFHI -> 0x0010
    public const int IMAGE_REL_PPC_REFHI = 16;

    /// IMAGE_REL_MIPS_PAIR -> 0x0025
    public const int IMAGE_REL_MIPS_PAIR = 37;

    /// IMAGE_REL_PPC_GPREL -> 0x0015
    public const int IMAGE_REL_PPC_GPREL = 21;

    /// IMAGE_REL_M32R_PAIR -> 0x000B
    public const int IMAGE_REL_M32R_PAIR = 11;

    /// IMAGE_REL_CEF_TOKEN -> 0x0006
    public const int IMAGE_REL_CEF_TOKEN = 6;

    /// IMAGE_REL_CEE_TOKEN -> 0x0006
    public const int IMAGE_REL_CEE_TOKEN = 6;

    /// IMAGE_REL_BASED_LOW -> 2
    public const int IMAGE_REL_BASED_LOW = 2;

    /// IMAGE_REL_ARM_TOKEN -> 0x0005
    public const int IMAGE_REL_ARM_TOKEN = 5;

    /// IMAGE_REL_ARM_BLX24 -> 0x0008
    public const int IMAGE_REL_ARM_BLX24 = 8;

    /// IMAGE_REL_ARM_BLX11 -> 0x0009
    public const int IMAGE_REL_ARM_BLX11 = 9;

    /// IMAGE_REL_AM_SECREL -> 0x0007
    public const int IMAGE_REL_AM_SECREL = 7;

    /// IMAGE_REL_AM_CALL32 -> 0x0003
    public const int IMAGE_REL_AM_CALL32 = 3;

    /// IMAGE_REL_AM_ADDR32 -> 0x0001
    public const int IMAGE_REL_AM_ADDR32 = 1;

    /// IMAGE_OS2_SIGNATURE -> 0x454E
    public const int IMAGE_OS2_SIGNATURE = 17742;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_FIRST_SECTION -> "(ntheader) ((PIMAGE_SECTION_HEADER)        
    /// ((ULONG_PTR)ntheader +                                              
    /// FIELD_OFFSET( IMAGE_NT_HEADERS, OptionalHeader ) +                 
    /// ((PIMAGE_NT_HEADERS)(ntheader))->FileHeader.SizeOfOptionalHeader   
    /// ))"
    public const string IMAGE_FIRST_SECTION = @"(ntheader) ((PIMAGE_SECTION_HEADER)        
    ((ULONG_PTR)ntheader +                                              
     FIELD_OFFSET( IMAGE_NT_HEADERS, OptionalHeader ) +                 
     ((PIMAGE_NT_HEADERS)(ntheader))->FileHeader.SizeOfOptionalHeader   
    ))";

    /// IMAGE_DOS_SIGNATURE -> 0x5A4D
    public const int IMAGE_DOS_SIGNATURE = 23117;

    /// IMAGE_ARCHIVE_START -> "!
    /// <arch>\n"
    public const string IMAGE_ARCHIVE_START = "!<arch>\\n";

    /// IMAGE_SYM_TYPE_MOE -> 0x000B
    public const int IMAGE_SYM_TYPE_MOE = 11;

    /// IMAGE_SYM_TYPE_INT -> 0x0004
    public const int IMAGE_SYM_TYPE_INT = 4;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_SYM_ABSOLUTE -> "(SHORT) -1"
    public const string IMAGE_SYM_ABSOLUTE = "(SHORT) -1";

    /// IMAGE_SCN_MEM_READ -> 0x40000000
    public const int IMAGE_SCN_MEM_READ = 1073741824;

    /// IMAGE_SCN_LNK_INFO -> 0x00000200
    public const int IMAGE_SCN_LNK_INFO = 512;

    /// IMAGE_SCN_CNT_CODE -> 0x00000020
    public const int IMAGE_SCN_CNT_CODE = 32;

    /// IMAGE_REL_PPC_PAIR -> 0x0012
    public const int IMAGE_REL_PPC_PAIR = 18;

    /// IMAGE_REL_AM_TOKEN -> 0x0009
    public const int IMAGE_REL_AM_TOKEN = 9;

    /// IMAGE_ORDINAL_FLAG -> IMAGE_ORDINAL_FLAG32
    public const int IMAGE_ORDINAL_FLAG = IMAGE_ORDINAL_FLAG32;

    /// IMAGE_NT_SIGNATURE -> 0x00004550
    public const int IMAGE_NT_SIGNATURE = 17744;

    /// IMAGE_REL_PPC_NEG -> 0x0100
    public const int IMAGE_REL_PPC_NEG = 256;

    /// IMAGE_FILE_SYSTEM -> 0x1000
    public const int IMAGE_FILE_SYSTEM = 4096;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_SYM_DEBUG -> "(SHORT) -2"
    public const string IMAGE_SYM_DEBUG = "(SHORT) -2";

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_ORDINAL -> "(Ordinal) IMAGE_ORDINAL32(Ordinal)"
    public const string IMAGE_ORDINAL = "(Ordinal) IMAGE_ORDINAL32(Ordinal)";

    /// IMAGE_FILE_DLL -> 0x2000
    public const int IMAGE_FILE_DLL = 8192;

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_ORDINAL32 -> "(Ordinal) (Ordinal & 0xffff)"
    public const string IMAGE_ORDINAL32 = "(Ordinal) (Ordinal & 0xffff)";

    /// Warning: Generation of Method Macros is not supported at this time
    /// IMAGE_ORDINAL64 -> "(Ordinal) (Ordinal & 0xffff)"
    public const string IMAGE_ORDINAL64 = "(Ordinal) (Ordinal & 0xffff)";

    /// IMAGE_SCN_GPREL -> 0x00008000
    public const int IMAGE_SCN_GPREL = 32768;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_ALPHA64_RUNTIME_FUNCTION_ENTRY
  {
    /// ULONGLONG->unsigned __int64
    public ulong BeginAddress;

    /// ULONGLONG->unsigned __int64
    public ulong EndAddress;

    /// ULONGLONG->unsigned __int64
    public ulong ExceptionHandler;

    /// ULONGLONG->unsigned __int64
    public ulong HandlerData;

    /// ULONGLONG->unsigned __int64
    public ulong PrologEndAddress;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_ALPHA_RUNTIME_FUNCTION_ENTRY
  {
    /// DWORD->unsigned int
    public uint BeginAddress;

    /// DWORD->unsigned int
    public uint EndAddress;

    /// DWORD->unsigned int
    public uint ExceptionHandler;

    /// DWORD->unsigned int
    public uint HandlerData;

    /// DWORD->unsigned int
    public uint PrologEndAddress;
  }

  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
  public struct IMAGE_RESOURCE_DIRECTORY_STRING
  {
    /// WORD->unsigned short
    public ushort Length;

    /// CHAR[1]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] public string NameString;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_CE_RUNTIME_FUNCTION_ENTRY
  {
    /// DWORD->unsigned int
    public uint FuncStart;

    /// PrologLen : 8
    /// FuncLen : 22
    /// ThirtyTwoBit : 1
    /// ExceptionFlag : 1
    public uint bitvector1;

    public uint PrologLen
    {
      get { return (((bitvector1 & 255u))); }
      set { bitvector1 = (((value | bitvector1))); }
    }

    public uint FuncLen
    {
      get
      {
        return ((((bitvector1 & 1073741568u)
                  /256)));
      }
      set
      {
        bitvector1 = ((((value*256)
                        | bitvector1)));
      }
    }

    public uint ThirtyTwoBit
    {
      get
      {
        return ((((bitvector1 & 1073741824u)
                  /1073741824)));
      }
      set
      {
        bitvector1 = ((((value*1073741824)
                        | bitvector1)));
      }
    }

    public uint ExceptionFlag
    {
      get
      {
        return ((((bitvector1 & 2147483648u)
                  /2147483648)));
      }
      set
      {
        bitvector1 = ((((value*2147483648)
                        | bitvector1)));
      }
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_RESOURCE_DIRECTORY_ENTRY
  {
    /// Anonymous_cfd23939_9500_4160_98e5_2192e35f1c84
    public Anonymous_cfd23939_9500_4160_98e5_2192e35f1c84 Union1;

    /// Anonymous_c8743c50_a79a_47b5_a663_6d16f2240a64
    public Anonymous_c8743c50_a79a_47b5_a663_6d16f2240a64 Union2;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_BOUND_IMPORT_DESCRIPTOR
  {
    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// WORD->unsigned short
    public ushort OffsetModuleName;

    /// WORD->unsigned short
    public ushort NumberOfModuleForwarderRefs;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_RUNTIME_FUNCTION_ENTRY
  {
    /// DWORD->unsigned int
    public uint BeginAddress;

    /// DWORD->unsigned int
    public uint EndAddress;

    /// DWORD->unsigned int
    public uint UnwindInfoAddress;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_SEPARATE_DEBUG_HEADER
  {
    /// WORD->unsigned short
    public ushort Signature;

    /// WORD->unsigned short
    public ushort Flags;

    /// WORD->unsigned short
    public ushort Machine;

    /// WORD->unsigned short
    public ushort Characteristics;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// DWORD->unsigned int
    public uint CheckSum;

    /// DWORD->unsigned int
    public uint ImageBase;

    /// DWORD->unsigned int
    public uint SizeOfImage;

    /// DWORD->unsigned int
    public uint NumberOfSections;

    /// DWORD->unsigned int
    public uint ExportedNamesSize;

    /// DWORD->unsigned int
    public uint DebugDirectorySize;

    /// DWORD->unsigned int
    public uint SectionAlignment;

    /// DWORD[2]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)] public uint[] Reserved;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_ARCHIVE_MEMBER_HEADER
  {
    /// BYTE[16]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)] public byte[] Name;

    /// BYTE[12]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)] public byte[] Date;

    /// BYTE[6]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)] public byte[] UserID;

    /// BYTE[6]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)] public byte[] GroupID;

    /// BYTE[8]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] public byte[] Mode;

    /// BYTE[10]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)] public byte[] Size;

    /// BYTE[2]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)] public byte[] EndHeader;
  }

  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  public struct IMAGE_RESOURCE_DIR_STRING_U
  {
    /// WORD->unsigned short
    public ushort Length;

    /// WCHAR[1]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] public string NameString;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_ROM_OPTIONAL_HEADER
  {
    /// WORD->unsigned short
    public ushort Magic;

    /// BYTE->unsigned char
    public byte MajorLinkerVersion;

    /// BYTE->unsigned char
    public byte MinorLinkerVersion;

    /// DWORD->unsigned int
    public uint SizeOfCode;

    /// DWORD->unsigned int
    public uint SizeOfInitializedData;

    /// DWORD->unsigned int
    public uint SizeOfUninitializedData;

    /// DWORD->unsigned int
    public uint AddressOfEntryPoint;

    /// DWORD->unsigned int
    public uint BaseOfCode;

    /// DWORD->unsigned int
    public uint BaseOfData;

    /// DWORD->unsigned int
    public uint BaseOfBss;

    /// DWORD->unsigned int
    public uint GprMask;

    /// DWORD[4]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)] public uint[] CprMask;

    /// DWORD->unsigned int
    public uint GpValue;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_RESOURCE_DATA_ENTRY
  {
    /// DWORD->unsigned int
    public uint OffsetToData;

    /// DWORD->unsigned int
    public uint Size;

    /// DWORD->unsigned int
    public uint CodePage;

    /// DWORD->unsigned int
    public uint Reserved;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_COFF_SYMBOLS_HEADER
  {
    /// DWORD->unsigned int
    public uint NumberOfSymbols;

    /// DWORD->unsigned int
    public uint LvaToFirstSymbol;

    /// DWORD->unsigned int
    public uint NumberOfLinenumbers;

    /// DWORD->unsigned int
    public uint LvaToFirstLinenumber;

    /// DWORD->unsigned int
    public uint RvaToFirstByteOfCode;

    /// DWORD->unsigned int
    public uint RvaToLastByteOfCode;

    /// DWORD->unsigned int
    public uint RvaToFirstByteOfData;

    /// DWORD->unsigned int
    public uint RvaToLastByteOfData;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_BOUND_FORWARDER_REF
  {
    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// WORD->unsigned short
    public ushort OffsetModuleName;

    /// WORD->unsigned short
    public ushort Reserved;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_RESOURCE_DIRECTORY
  {
    /// DWORD->unsigned int
    public uint Characteristics;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// WORD->unsigned short
    public ushort MajorVersion;

    /// WORD->unsigned short
    public ushort MinorVersion;

    /// WORD->unsigned short
    public ushort NumberOfNamedEntries;

    /// WORD->unsigned short
    public ushort NumberOfIdEntries;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_OPTIONAL_HEADER64
  {
    /// WORD->unsigned short
    public ushort Magic;

    /// BYTE->unsigned char
    public byte MajorLinkerVersion;

    /// BYTE->unsigned char
    public byte MinorLinkerVersion;

    /// DWORD->unsigned int
    public uint SizeOfCode;

    /// DWORD->unsigned int
    public uint SizeOfInitializedData;

    /// DWORD->unsigned int
    public uint SizeOfUninitializedData;

    /// DWORD->unsigned int
    public uint AddressOfEntryPoint;

    /// DWORD->unsigned int
    public uint BaseOfCode;

    /// ULONGLONG->unsigned __int64
    public ulong ImageBase;

    /// DWORD->unsigned int
    public uint SectionAlignment;

    /// DWORD->unsigned int
    public uint FileAlignment;

    /// WORD->unsigned short
    public ushort MajorOperatingSystemVersion;

    /// WORD->unsigned short
    public ushort MinorOperatingSystemVersion;

    /// WORD->unsigned short
    public ushort MajorImageVersion;

    /// WORD->unsigned short
    public ushort MinorImageVersion;

    /// WORD->unsigned short
    public ushort MajorSubsystemVersion;

    /// WORD->unsigned short
    public ushort MinorSubsystemVersion;

    /// DWORD->unsigned int
    public uint Win32VersionValue;

    /// DWORD->unsigned int
    public uint SizeOfImage;

    /// DWORD->unsigned int
    public uint SizeOfHeaders;

    /// DWORD->unsigned int
    public uint CheckSum;

    /// WORD->unsigned short
    public ushort Subsystem;

    /// WORD->unsigned short
    public ushort DllCharacteristics;

    /// ULONGLONG->unsigned __int64
    public ulong SizeOfStackReserve;

    /// ULONGLONG->unsigned __int64
    public ulong SizeOfStackCommit;

    /// ULONGLONG->unsigned __int64
    public ulong SizeOfHeapReserve;

    /// ULONGLONG->unsigned __int64
    public ulong SizeOfHeapCommit;

    /// DWORD->unsigned int
    public uint LoaderFlags;

    /// DWORD->unsigned int
    public uint NumberOfRvaAndSizes;

    /// IMAGE_DATA_DIRECTORY[16]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)] public
      IMAGE_DATA_DIRECTORY[] DataDirectory;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_IMPORT_DESCRIPTOR
  {
    /// Anonymous_7dadb22a_8bbe_4747_9d2a_2d35c978fd6b
    public Anonymous_7dadb22a_8bbe_4747_9d2a_2d35c978fd6b Union1;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// DWORD->unsigned int
    public uint ForwarderChain;

    /// DWORD->unsigned int
    public uint Name;

    /// DWORD->unsigned int
    public uint FirstThunk;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_FUNCTION_ENTRY64
  {
    /// ULONGLONG->unsigned __int64
    public ulong StartingAddress;

    /// ULONGLONG->unsigned __int64
    public ulong EndingAddress;

    /// Anonymous_02cf5c90_12c2_42ca_832a_8cd3aa7fc46f
    public Anonymous_02cf5c90_12c2_42ca_832a_8cd3aa7fc46f Union1;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_EXPORT_DIRECTORY
  {
    /// DWORD->unsigned int
    public uint Characteristics;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// WORD->unsigned short
    public ushort MajorVersion;

    /// WORD->unsigned short
    public ushort MinorVersion;

    /// DWORD->unsigned int
    public uint Name;

    /// DWORD->unsigned int
    public uint Base;

    /// DWORD->unsigned int
    public uint NumberOfFunctions;

    /// DWORD->unsigned int
    public uint NumberOfNames;

    /// DWORD->unsigned int
    public uint AddressOfFunctions;

    /// DWORD->unsigned int
    public uint AddressOfNames;

    /// DWORD->unsigned int
    public uint AddressOfNameOrdinals;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_TLS_DIRECTORY32
  {
    /// DWORD->unsigned int
    public uint StartAddressOfRawData;

    /// DWORD->unsigned int
    public uint EndAddressOfRawData;

    /// DWORD->unsigned int
    public uint AddressOfIndex;

    /// DWORD->unsigned int
    public uint AddressOfCallBacks;

    /// DWORD->unsigned int
    public uint SizeOfZeroFill;

    /// DWORD->unsigned int
    public uint Characteristics;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_TLS_DIRECTORY64
  {
    /// ULONGLONG->unsigned __int64
    public ulong StartAddressOfRawData;

    /// ULONGLONG->unsigned __int64
    public ulong EndAddressOfRawData;

    /// ULONGLONG->unsigned __int64
    public ulong AddressOfIndex;

    /// ULONGLONG->unsigned __int64
    public ulong AddressOfCallBacks;

    /// DWORD->unsigned int
    public uint SizeOfZeroFill;

    /// DWORD->unsigned int
    public uint Characteristics;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_OPTIONAL_HEADER32
  {
    /// WORD->unsigned short
    public ushort Magic;

    /// BYTE->unsigned char
    public byte MajorLinkerVersion;

    /// BYTE->unsigned char
    public byte MinorLinkerVersion;

    /// DWORD->unsigned int
    public uint SizeOfCode;

    /// DWORD->unsigned int
    public uint SizeOfInitializedData;

    /// DWORD->unsigned int
    public uint SizeOfUninitializedData;

    /// DWORD->unsigned int
    public uint AddressOfEntryPoint;

    /// DWORD->unsigned int
    public uint BaseOfCode;

    /// DWORD->unsigned int
    public uint BaseOfData;

    /// DWORD->unsigned int
    public uint ImageBase;

    /// DWORD->unsigned int
    public uint SectionAlignment;

    /// DWORD->unsigned int
    public uint FileAlignment;

    /// WORD->unsigned short
    public ushort MajorOperatingSystemVersion;

    /// WORD->unsigned short
    public ushort MinorOperatingSystemVersion;

    /// WORD->unsigned short
    public ushort MajorImageVersion;

    /// WORD->unsigned short
    public ushort MinorImageVersion;

    /// WORD->unsigned short
    public ushort MajorSubsystemVersion;

    /// WORD->unsigned short
    public ushort MinorSubsystemVersion;

    /// DWORD->unsigned int
    public uint Win32VersionValue;

    /// DWORD->unsigned int
    public uint SizeOfImage;

    /// DWORD->unsigned int
    public uint SizeOfHeaders;

    /// DWORD->unsigned int
    public uint CheckSum;

    /// WORD->unsigned short
    public ushort Subsystem;

    /// WORD->unsigned short
    public ushort DllCharacteristics;

    /// DWORD->unsigned int
    public uint SizeOfStackReserve;

    /// DWORD->unsigned int
    public uint SizeOfStackCommit;

    /// DWORD->unsigned int
    public uint SizeOfHeapReserve;

    /// DWORD->unsigned int
    public uint SizeOfHeapCommit;

    /// DWORD->unsigned int
    public uint LoaderFlags;

    /// DWORD->unsigned int
    public uint NumberOfRvaAndSizes;

    /// IMAGE_DATA_DIRECTORY[16]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)] public
      IMAGE_DATA_DIRECTORY[] DataDirectory;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_DEBUG_DIRECTORY
  {
    /// DWORD->unsigned int
    public uint Characteristics;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// WORD->unsigned short
    public ushort MajorVersion;

    /// WORD->unsigned short
    public ushort MinorVersion;

    /// DWORD->unsigned int
    public uint Type;

    /// DWORD->unsigned int
    public uint SizeOfData;

    /// DWORD->unsigned int
    public uint AddressOfRawData;

    /// DWORD->unsigned int
    public uint PointerToRawData;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_BASE_RELOCATION
  {
    /// DWORD->unsigned int
    public uint VirtualAddress;

    /// DWORD->unsigned int
    public uint SizeOfBlock;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_SECTION_HEADER
  {
    /// BYTE[8]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] public byte[] Name;

    /// Anonymous_c9386319_923c_4f10_ad71_12ce6f4c7b4e
    public Anonymous_c9386319_923c_4f10_ad71_12ce6f4c7b4e Misc;

    /// DWORD->unsigned int
    public uint VirtualAddress;

    /// DWORD->unsigned int
    public uint SizeOfRawData;

    /// DWORD->unsigned int
    public uint PointerToRawData;

    /// DWORD->unsigned int
    public uint PointerToRelocations;

    /// DWORD->unsigned int
    public uint PointerToLinenumbers;

    /// WORD->unsigned short
    public ushort NumberOfRelocations;

    /// WORD->unsigned short
    public ushort NumberOfLinenumbers;

    /// DWORD->unsigned int
    public uint Characteristics;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_IMPORT_BY_NAME
  {
    /// WORD->unsigned short
    public ushort Hint;

    /// BYTE[1]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)] public byte[] Name;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_FUNCTION_ENTRY
  {
    /// DWORD->unsigned int
    public uint StartingAddress;

    /// DWORD->unsigned int
    public uint EndingAddress;

    /// DWORD->unsigned int
    public uint EndOfPrologue;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_DATA_DIRECTORY
  {
    /// DWORD->unsigned int
    public uint VirtualAddress;

    /// DWORD->unsigned int
    public uint Size;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_THUNK_DATA64
  {
    /// Anonymous_9ae169eb_8d9d_4c08_91c7_4838cb279a69
    public Anonymous_9ae169eb_8d9d_4c08_91c7_4838cb279a69 u1;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_THUNK_DATA32
  {
    /// Anonymous_88e17f4a_56bc_4ac7_a088_8ac013993c30
    public Anonymous_88e17f4a_56bc_4ac7_a088_8ac013993c30 u1;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_NT_HEADERS64
  {
    /// DWORD->unsigned int
    public uint Signature;

    /// IMAGE_FILE_HEADER->_IMAGE_FILE_HEADER
    public IMAGE_FILE_HEADER FileHeader;

    /// IMAGE_OPTIONAL_HEADER64->_IMAGE_OPTIONAL_HEADER64
    public IMAGE_OPTIONAL_HEADER64 OptionalHeader;
  }

  /// Return Type: void
  /// DllHandle: PVOID->void*
  /// Reason: DWORD->unsigned int
  /// Reserved: PVOID->void*
  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  public delegate void PIMAGE_TLS_CALLBACK(IntPtr DllHandle, uint Reason, IntPtr Reserved);

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_ROM_HEADERS
  {
    /// IMAGE_FILE_HEADER->_IMAGE_FILE_HEADER
    public IMAGE_FILE_HEADER FileHeader;

    /// IMAGE_ROM_OPTIONAL_HEADER->_IMAGE_ROM_OPTIONAL_HEADER
    public IMAGE_ROM_OPTIONAL_HEADER OptionalHeader;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_FILE_HEADER
  {
    /// WORD->unsigned short
    public ushort Machine;

    /// WORD->unsigned short
    public ushort NumberOfSections;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// DWORD->unsigned int
    public uint PointerToSymbolTable;

    /// DWORD->unsigned int
    public uint NumberOfSymbols;

    /// WORD->unsigned short
    public ushort SizeOfOptionalHeader;

    /// WORD->unsigned short
    public ushort Characteristics;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_VXD_HEADER
  {
    /// WORD->unsigned short
    public ushort e32_magic;

    /// BYTE->unsigned char
    public byte e32_border;

    /// BYTE->unsigned char
    public byte e32_worder;

    /// DWORD->unsigned int
    public uint e32_level;

    /// WORD->unsigned short
    public ushort e32_cpu;

    /// WORD->unsigned short
    public ushort e32_os;

    /// DWORD->unsigned int
    public uint e32_ver;

    /// DWORD->unsigned int
    public uint e32_mflags;

    /// DWORD->unsigned int
    public uint e32_mpages;

    /// DWORD->unsigned int
    public uint e32_startobj;

    /// DWORD->unsigned int
    public uint e32_eip;

    /// DWORD->unsigned int
    public uint e32_stackobj;

    /// DWORD->unsigned int
    public uint e32_esp;

    /// DWORD->unsigned int
    public uint e32_pagesize;

    /// DWORD->unsigned int
    public uint e32_lastpagesize;

    /// DWORD->unsigned int
    public uint e32_fixupsize;

    /// DWORD->unsigned int
    public uint e32_fixupsum;

    /// DWORD->unsigned int
    public uint e32_ldrsize;

    /// DWORD->unsigned int
    public uint e32_ldrsum;

    /// DWORD->unsigned int
    public uint e32_objtab;

    /// DWORD->unsigned int
    public uint e32_objcnt;

    /// DWORD->unsigned int
    public uint e32_objmap;

    /// DWORD->unsigned int
    public uint e32_itermap;

    /// DWORD->unsigned int
    public uint e32_rsrctab;

    /// DWORD->unsigned int
    public uint e32_rsrccnt;

    /// DWORD->unsigned int
    public uint e32_restab;

    /// DWORD->unsigned int
    public uint e32_enttab;

    /// DWORD->unsigned int
    public uint e32_dirtab;

    /// DWORD->unsigned int
    public uint e32_dircnt;

    /// DWORD->unsigned int
    public uint e32_fpagetab;

    /// DWORD->unsigned int
    public uint e32_frectab;

    /// DWORD->unsigned int
    public uint e32_impmod;

    /// DWORD->unsigned int
    public uint e32_impmodcnt;

    /// DWORD->unsigned int
    public uint e32_impproc;

    /// DWORD->unsigned int
    public uint e32_pagesum;

    /// DWORD->unsigned int
    public uint e32_datapage;

    /// DWORD->unsigned int
    public uint e32_preload;

    /// DWORD->unsigned int
    public uint e32_nrestab;

    /// DWORD->unsigned int
    public uint e32_cbnrestab;

    /// DWORD->unsigned int
    public uint e32_nressum;

    /// DWORD->unsigned int
    public uint e32_autodata;

    /// DWORD->unsigned int
    public uint e32_debuginfo;

    /// DWORD->unsigned int
    public uint e32_debuglen;

    /// DWORD->unsigned int
    public uint e32_instpreload;

    /// DWORD->unsigned int
    public uint e32_instdemand;

    /// DWORD->unsigned int
    public uint e32_heapsize;

    /// BYTE[12]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)] public byte[] e32_res3;

    /// DWORD->unsigned int
    public uint e32_winresoff;

    /// DWORD->unsigned int
    public uint e32_winreslen;

    /// WORD->unsigned short
    public ushort e32_devid;

    /// WORD->unsigned short
    public ushort e32_ddkver;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_RELOCATION
  {
    /// Anonymous_8cf464b6_e59d_4bc1_bc7d_fde4719bfe18
    public Anonymous_8cf464b6_e59d_4bc1_bc7d_fde4719bfe18 Union1;

    /// DWORD->unsigned int
    public uint SymbolTableIndex;

    /// WORD->unsigned short
    public ushort Type;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_OS2_HEADER
  {
    /// WORD->unsigned short
    public ushort ne_magic;

    /// CHAR->char
    public byte ne_ver;

    /// CHAR->char
    public byte ne_rev;

    /// WORD->unsigned short
    public ushort ne_enttab;

    /// WORD->unsigned short
    public ushort ne_cbenttab;

    /// LONG->int
    public int ne_crc;

    /// WORD->unsigned short
    public ushort ne_flags;

    /// WORD->unsigned short
    public ushort ne_autodata;

    /// WORD->unsigned short
    public ushort ne_heap;

    /// WORD->unsigned short
    public ushort ne_stack;

    /// LONG->int
    public int ne_csip;

    /// LONG->int
    public int ne_sssp;

    /// WORD->unsigned short
    public ushort ne_cseg;

    /// WORD->unsigned short
    public ushort ne_cmod;

    /// WORD->unsigned short
    public ushort ne_cbnrestab;

    /// WORD->unsigned short
    public ushort ne_segtab;

    /// WORD->unsigned short
    public ushort ne_rsrctab;

    /// WORD->unsigned short
    public ushort ne_restab;

    /// WORD->unsigned short
    public ushort ne_modtab;

    /// WORD->unsigned short
    public ushort ne_imptab;

    /// LONG->int
    public int ne_nrestab;

    /// WORD->unsigned short
    public ushort ne_cmovent;

    /// WORD->unsigned short
    public ushort ne_align;

    /// WORD->unsigned short
    public ushort ne_cres;

    /// BYTE->unsigned char
    public byte ne_exetyp;

    /// BYTE->unsigned char
    public byte ne_flagsothers;

    /// WORD->unsigned short
    public ushort ne_pretthunks;

    /// WORD->unsigned short
    public ushort ne_psegrefbytes;

    /// WORD->unsigned short
    public ushort ne_swaparea;

    /// WORD->unsigned short
    public ushort ne_expver;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_LINENUMBER
  {
    /// Anonymous_9458c9ac_2eca_481f_8912_f5ffcf5913b6
    public Anonymous_9458c9ac_2eca_481f_8912_f5ffcf5913b6 Type;

    /// WORD->unsigned short
    public ushort Linenumber;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_NT_HEADERS32
  {
    /// DWORD->unsigned int
    public uint Signature;

    /// IMAGE_FILE_HEADER->_IMAGE_FILE_HEADER
    public IMAGE_FILE_HEADER FileHeader;

    /// IMAGE_OPTIONAL_HEADER32->_IMAGE_OPTIONAL_HEADER
    public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_DOS_HEADER
  {
    /// WORD->unsigned short
    public ushort e_magic;

    /// WORD->unsigned short
    public ushort e_cblp;

    /// WORD->unsigned short
    public ushort e_cp;

    /// WORD->unsigned short
    public ushort e_crlc;

    /// WORD->unsigned short
    public ushort e_cparhdr;

    /// WORD->unsigned short
    public ushort e_minalloc;

    /// WORD->unsigned short
    public ushort e_maxalloc;

    /// WORD->unsigned short
    public ushort e_ss;

    /// WORD->unsigned short
    public ushort e_sp;

    /// WORD->unsigned short
    public ushort e_csum;

    /// WORD->unsigned short
    public ushort e_ip;

    /// WORD->unsigned short
    public ushort e_cs;

    /// WORD->unsigned short
    public ushort e_lfarlc;

    /// WORD->unsigned short
    public ushort e_ovno;

    /// WORD[4]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U2)] public ushort[] e_res;

    /// WORD->unsigned short
    public ushort e_oemid;

    /// WORD->unsigned short
    public ushort e_oeminfo;

    /// WORD[10]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U2)] public ushort[] e_res2;

    /// LONG->int
    public int e_lfanew;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_DEBUG_MISC
  {
    /// DWORD->unsigned int
    public uint DataType;

    /// DWORD->unsigned int
    public uint Length;

    /// BOOLEAN->BYTE->unsigned char
    public byte Unicode;

    /// BYTE[3]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)] public byte[] Reserved;

    /// BYTE[1]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)] public byte[] Data;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct IMAGE_AUX_SYMBOL
  {
    /// Anonymous_3cdcd72e_692f_4916_8874_aac0ab7bab52
    [FieldOffset(0)] public Anonymous_3cdcd72e_692f_4916_8874_aac0ab7bab52 Sym;

    /// Anonymous_f07de348_4b52_4b8c_b360_6bb20b8e44e5
    [FieldOffset(0)] public Anonymous_f07de348_4b52_4b8c_b360_6bb20b8e44e5 File;

    /// Anonymous_697c29df_00ad_48da_88b3_fa9cfa1f6467
    [FieldOffset(0)] public Anonymous_697c29df_00ad_48da_88b3_fa9cfa1f6467 Section;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_SYMBOL
  {
    /// Anonymous_c6363f3e_2cdc_4c92_81ea_a84a1d4b42a3
    public Anonymous_c6363f3e_2cdc_4c92_81ea_a84a1d4b42a3 N;

    /// DWORD->unsigned int
    public uint Value;

    /// SHORT->short
    public short SectionNumber;

    /// WORD->unsigned short
    public ushort Type;

    /// BYTE->unsigned char
    public byte StorageClass;

    /// BYTE->unsigned char
    public byte NumberOfAuxSymbols;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_AUX_SYMBOL_TOKEN_DEF
  {
    /// BYTE->unsigned char
    public byte bAuxType;

    /// BYTE->unsigned char
    public byte bReserved;

    /// DWORD->unsigned int
    public uint SymbolTableIndex;

    /// BYTE[12]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)] public byte[] rgbReserved;
  }

  public enum IMAGE_AUX_SYMBOL_TYPE
  {
    /// IMAGE_AUX_SYMBOL_TYPE_TOKEN_DEF -> 1
    IMAGE_AUX_SYMBOL_TYPE_TOKEN_DEF = 1,
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_COR20_HEADER
  {
    /// DWORD->unsigned int
    public uint cb;

    /// WORD->unsigned short
    public ushort MajorRuntimeVersion;

    /// WORD->unsigned short
    public ushort MinorRuntimeVersion;

    /// IMAGE_DATA_DIRECTORY->_IMAGE_DATA_DIRECTORY
    public IMAGE_DATA_DIRECTORY MetaData;

    /// DWORD->unsigned int
    public uint Flags;

    /// DWORD->unsigned int
    public uint EntryPointToken;

    /// IMAGE_DATA_DIRECTORY->_IMAGE_DATA_DIRECTORY
    public IMAGE_DATA_DIRECTORY Resources;

    /// IMAGE_DATA_DIRECTORY->_IMAGE_DATA_DIRECTORY
    public IMAGE_DATA_DIRECTORY StrongNameSignature;

    /// IMAGE_DATA_DIRECTORY->_IMAGE_DATA_DIRECTORY
    public IMAGE_DATA_DIRECTORY CodeManagerTable;

    /// IMAGE_DATA_DIRECTORY->_IMAGE_DATA_DIRECTORY
    public IMAGE_DATA_DIRECTORY VTableFixups;

    /// IMAGE_DATA_DIRECTORY->_IMAGE_DATA_DIRECTORY
    public IMAGE_DATA_DIRECTORY ExportAddressTableJumps;

    /// IMAGE_DATA_DIRECTORY->_IMAGE_DATA_DIRECTORY
    public IMAGE_DATA_DIRECTORY ManagedNativeHeader;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_LOAD_CONFIG_DIRECTORY64
  {
    /// DWORD->unsigned int
    public uint Size;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// WORD->unsigned short
    public ushort MajorVersion;

    /// WORD->unsigned short
    public ushort MinorVersion;

    /// DWORD->unsigned int
    public uint GlobalFlagsClear;

    /// DWORD->unsigned int
    public uint GlobalFlagsSet;

    /// DWORD->unsigned int
    public uint CriticalSectionDefaultTimeout;

    /// ULONGLONG->unsigned __int64
    public ulong DeCommitFreeBlockThreshold;

    /// ULONGLONG->unsigned __int64
    public ulong DeCommitTotalFreeThreshold;

    /// ULONGLONG->unsigned __int64
    public ulong LockPrefixTable;

    /// ULONGLONG->unsigned __int64
    public ulong MaximumAllocationSize;

    /// ULONGLONG->unsigned __int64
    public ulong VirtualMemoryThreshold;

    /// ULONGLONG->unsigned __int64
    public ulong ProcessAffinityMask;

    /// DWORD->unsigned int
    public uint ProcessHeapFlags;

    /// WORD->unsigned short
    public ushort CSDVersion;

    /// WORD->unsigned short
    public ushort Reserved1;

    /// ULONGLONG->unsigned __int64
    public ulong EditList;

    /// ULONGLONG->unsigned __int64
    public ulong SecurityCookie;

    /// ULONGLONG->unsigned __int64
    public ulong SEHandlerTable;

    /// ULONGLONG->unsigned __int64
    public ulong SEHandlerCount;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_LOAD_CONFIG_DIRECTORY32
  {
    /// DWORD->unsigned int
    public uint Size;

    /// DWORD->unsigned int
    public uint TimeDateStamp;

    /// WORD->unsigned short
    public ushort MajorVersion;

    /// WORD->unsigned short
    public ushort MinorVersion;

    /// DWORD->unsigned int
    public uint GlobalFlagsClear;

    /// DWORD->unsigned int
    public uint GlobalFlagsSet;

    /// DWORD->unsigned int
    public uint CriticalSectionDefaultTimeout;

    /// DWORD->unsigned int
    public uint DeCommitFreeBlockThreshold;

    /// DWORD->unsigned int
    public uint DeCommitTotalFreeThreshold;

    /// DWORD->unsigned int
    public uint LockPrefixTable;

    /// DWORD->unsigned int
    public uint MaximumAllocationSize;

    /// DWORD->unsigned int
    public uint VirtualMemoryThreshold;

    /// DWORD->unsigned int
    public uint ProcessHeapFlags;

    /// DWORD->unsigned int
    public uint ProcessAffinityMask;

    /// WORD->unsigned short
    public ushort CSDVersion;

    /// WORD->unsigned short
    public ushort Reserved1;

    /// DWORD->unsigned int
    public uint EditList;

    /// DWORD->unsigned int
    public uint SecurityCookie;

    /// DWORD->unsigned int
    public uint SEHandlerTable;

    /// DWORD->unsigned int
    public uint SEHandlerCount;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_ARCHITECTURE_HEADER
  {
    /// AmaskValue : 1
    /// AnonymousMember1 : 7
    /// AmaskShift : 8
    /// AnonymousMember2 : 16
    public uint bitvector1;

    /// DWORD->unsigned int
    public uint FirstEntryRVA;

    public uint AmaskValue
    {
      get { return (((bitvector1 & 1u))); }
      set { bitvector1 = (((value | bitvector1))); }
    }

    public uint AnonymousMember1
    {
      get
      {
        return ((((bitvector1 & 254u)
                  /2)));
      }
      set
      {
        bitvector1 = ((((value*2)
                        | bitvector1)));
      }
    }

    public uint AmaskShift
    {
      get
      {
        return ((((bitvector1 & 65280u)
                  /256)));
      }
      set
      {
        bitvector1 = ((((value*256)
                        | bitvector1)));
      }
    }

    public uint AnonymousMember2
    {
      get
      {
        return ((((bitvector1 & 4294901760u)
                  /65536)));
      }
      set
      {
        bitvector1 = ((((value*65536)
                        | bitvector1)));
      }
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct IMAGE_ARCHITECTURE_ENTRY
  {
    /// DWORD->unsigned int
    public uint FixupInstRVA;

    /// DWORD->unsigned int
    public uint NewInst;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_cfd23939_9500_4160_98e5_2192e35f1c84
  {
    /// Anonymous_9745490c_3375_4320_bd20_bf98795b0e50
    [FieldOffset(0)] public Anonymous_9745490c_3375_4320_bd20_bf98795b0e50 Struct1;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint Name;

    /// WORD->unsigned short
    [FieldOffset(0)] public ushort Id;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_c8743c50_a79a_47b5_a663_6d16f2240a64
  {
    /// DWORD->unsigned int
    [FieldOffset(0)] public uint OffsetToData;

    /// Anonymous_e172b3d1_df10_4959_b941_c01d77f42733
    [FieldOffset(0)] public Anonymous_e172b3d1_df10_4959_b941_c01d77f42733 Struct1;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_7dadb22a_8bbe_4747_9d2a_2d35c978fd6b
  {
    /// DWORD->unsigned int
    [FieldOffset(0)] public uint Characteristics;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint OriginalFirstThunk;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_02cf5c90_12c2_42ca_832a_8cd3aa7fc46f
  {
    /// ULONGLONG->unsigned __int64
    [FieldOffset(0)] public ulong EndOfPrologue;

    /// ULONGLONG->unsigned __int64
    [FieldOffset(0)] public ulong UnwindInfoAddress;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_c9386319_923c_4f10_ad71_12ce6f4c7b4e
  {
    /// DWORD->unsigned int
    [FieldOffset(0)] public uint PhysicalAddress;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint VirtualSize;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_9ae169eb_8d9d_4c08_91c7_4838cb279a69
  {
    /// ULONGLONG->unsigned __int64
    [FieldOffset(0)] public ulong ForwarderString;

    /// ULONGLONG->unsigned __int64
    [FieldOffset(0)] public ulong Function;

    /// ULONGLONG->unsigned __int64
    [FieldOffset(0)] public ulong Ordinal;

    /// ULONGLONG->unsigned __int64
    [FieldOffset(0)] public ulong AddressOfData;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_88e17f4a_56bc_4ac7_a088_8ac013993c30
  {
    /// DWORD->unsigned int
    [FieldOffset(0)] public uint ForwarderString;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint Function;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint Ordinal;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint AddressOfData;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_8cf464b6_e59d_4bc1_bc7d_fde4719bfe18
  {
    /// DWORD->unsigned int
    [FieldOffset(0)] public uint VirtualAddress;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint RelocCount;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_9458c9ac_2eca_481f_8912_f5ffcf5913b6
  {
    /// DWORD->unsigned int
    [FieldOffset(0)] public uint SymbolTableIndex;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint VirtualAddress;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_3cdcd72e_692f_4916_8874_aac0ab7bab52
  {
    /// DWORD->unsigned int
    public uint TagIndex;

    /// Anonymous_996376cd_198e_4f94_b294_6f092ed08535
    public Anonymous_996376cd_198e_4f94_b294_6f092ed08535 Misc;

    /// Anonymous_d6929560_b153_442e_89bc_7373a0f636e0
    public Anonymous_d6929560_b153_442e_89bc_7373a0f636e0 FcnAry;

    /// WORD->unsigned short
    public ushort TvIndex;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_f07de348_4b52_4b8c_b360_6bb20b8e44e5
  {
    /// BYTE[18]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)] public byte[] Name;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_697c29df_00ad_48da_88b3_fa9cfa1f6467
  {
    /// DWORD->unsigned int
    public uint Length;

    /// WORD->unsigned short
    public ushort NumberOfRelocations;

    /// WORD->unsigned short
    public ushort NumberOfLinenumbers;

    /// DWORD->unsigned int
    public uint CheckSum;

    /// SHORT->short
    public short Number;

    /// BYTE->unsigned char
    public byte Selection;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_c6363f3e_2cdc_4c92_81ea_a84a1d4b42a3
  {
    /// BYTE[8]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] [FieldOffset(0)] public byte[]
      ShortName;

    /// Anonymous_907e307b_e326_41de_bac3_596645332f66
    [FieldOffset(0)] public Anonymous_907e307b_e326_41de_bac3_596645332f66 Name;

    /// DWORD[2]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)] [FieldOffset(0)] public uint[]
      LongName;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_9745490c_3375_4320_bd20_bf98795b0e50
  {
    /// NameOffset : 31
    /// NameIsString : 1
    public uint bitvector1;

    public uint NameOffset
    {
      get { return (((bitvector1 & 2147483647u))); }
      set { bitvector1 = (((value | bitvector1))); }
    }

    public uint NameIsString
    {
      get
      {
        return ((((bitvector1 & 2147483648u)
                  /2147483648)));
      }
      set
      {
        bitvector1 = ((((value*2147483648)
                        | bitvector1)));
      }
    }
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_e172b3d1_df10_4959_b941_c01d77f42733
  {
    /// OffsetToDirectory : 31
    /// DataIsDirectory : 1
    public uint bitvector1;

    public uint OffsetToDirectory
    {
      get { return (((bitvector1 & 2147483647u))); }
      set { bitvector1 = (((value | bitvector1))); }
    }

    public uint DataIsDirectory
    {
      get
      {
        return ((((bitvector1 & 2147483648u)
                  /2147483648)));
      }
      set
      {
        bitvector1 = ((((value*2147483648)
                        | bitvector1)));
      }
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_996376cd_198e_4f94_b294_6f092ed08535
  {
    /// Anonymous_6cd904db_e392_48a8_8a97_d1256010f471
    [FieldOffset(0)] public Anonymous_6cd904db_e392_48a8_8a97_d1256010f471 LnSz;

    /// DWORD->unsigned int
    [FieldOffset(0)] public uint TotalSize;
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Anonymous_d6929560_b153_442e_89bc_7373a0f636e0
  {
    /// Anonymous_8d75b279_16e0_4e65_b352_f627487a260f
    [FieldOffset(0)] public Anonymous_8d75b279_16e0_4e65_b352_f627487a260f Function;

    /// Anonymous_88ea22a4_7f27_4000_9e6a_caeb8d94a2fd
    [FieldOffset(0)] public Anonymous_88ea22a4_7f27_4000_9e6a_caeb8d94a2fd Array;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_907e307b_e326_41de_bac3_596645332f66
  {
    /// DWORD->unsigned int
    public uint Short;

    /// DWORD->unsigned int
    public uint Long;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_6cd904db_e392_48a8_8a97_d1256010f471
  {
    /// WORD->unsigned short
    public ushort Linenumber;

    /// WORD->unsigned short
    public ushort Size;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_8d75b279_16e0_4e65_b352_f627487a260f
  {
    /// DWORD->unsigned int
    public uint PointerToLinenumber;

    /// DWORD->unsigned int
    public uint PointerToNextFunction;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Anonymous_88ea22a4_7f27_4000_9e6a_caeb8d94a2fd
  {
    /// WORD[4]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U2)] public ushort[] Dimension;
  }
}