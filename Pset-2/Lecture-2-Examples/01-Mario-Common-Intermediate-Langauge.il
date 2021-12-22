// Type: _01_Mario.Program 
// Assembly: 01-Mario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 63BDC93E-14FF-4B35-B4EA-BD7F5EDD811B
// Location: D:\Libraries\Desktop\01-Mario.dll
// Sequence point data from decompiler

.class public auto ansi beforefieldinit
  _01_Mario.Program
    extends [System.Runtime]System.Object
{

  .method private hidebysig static void
    Main(
      string[] args
    ) cil managed
  {
    .entrypoint
    .maxstack 2
    .locals init (
      [0] int32 num1,
      [1] int32 num2,
      [2] bool V_2,
      [3] int32 index,
      [4] int32 writeCount,
      [5] int32 V_5,
      [6] bool V_6
    )

    IL_0000: nop
    // start of loop, entry point: IL_0001
      IL_0001: nop

      // [20 9 - 20 40]
      IL_0002: ldstr        "Height: "
      IL_0007: call         int32 [Tao.Help]Tao.Help.Input::GetInt(string)
      IL_000c: stloc.0      // num1

      // [21 9 - 21 20]
      IL_000d: ldloc.0      // num1
      IL_000e: stloc.1      // num2
      IL_000f: nop

      // [23 7 - 23 36]
      IL_0010: ldloc.0      // num1
      IL_0011: ldc.i4.1
      IL_0012: blt.s        IL_001a

      IL_0014: ldloc.0      // num1
      IL_0015: ldc.i4.8
      IL_0016: cgt
      IL_0018: br.s         IL_001b
      IL_001a: ldc.i4.1
      IL_001b: stloc.2      // V_2
      IL_001c: ldloc.2      // V_2
      IL_001d: brtrue.s     IL_0001
    // end of loop

    // [24 12 - 24 25]
    IL_001f: ldc.i4.0
    IL_0020: stloc.3      // index

    IL_0021: br.s         IL_004c
    // start of loop, entry point: IL_004c
      IL_0023: nop

      // [26 9 - 26 31]
      IL_0024: ldloc.3      // index
      IL_0025: stloc.s      writeCount

      // [27 9 - 27 49]
      IL_0027: ldloc.1      // num2
      IL_0028: ldloc.s      writeCount
      IL_002a: sub
      IL_002b: stloc.s      V_5
      IL_002d: ldc.i4.s     32 // 0x20
      IL_002f: ldloc.s      V_5
      IL_0031: call         void _01_Mario.Program::Iterator(char, int32)
      IL_0036: nop

      // [28 9 - 28 42]
      IL_0037: ldc.i4.s     35 // 0x23
      IL_0039: ldloc.s      writeCount
      IL_003b: call         void _01_Mario.Program::Iterator(char, int32)
      IL_0040: nop

      // [29 9 - 29 28]
      IL_0041: call         void [System.Console]System.Console::WriteLine()
      IL_0046: nop
      IL_0047: nop

      // [24 42 - 24 49]
      IL_0048: ldloc.3      // index
      IL_0049: ldc.i4.1
      IL_004a: add
      IL_004b: stloc.3      // index

      // [24 27 - 24 40]
      IL_004c: ldloc.3      // index
      IL_004d: ldloc.0      // num1
      IL_004e: cgt
      IL_0050: ldc.i4.0
      IL_0051: ceq
      IL_0053: stloc.s      V_6

      IL_0055: ldloc.s      V_6
      IL_0057: brtrue.s     IL_0023
    // end of loop
    IL_0059: ret

  } // end of method Program::Main

  .method private hidebysig static void
    Iterator(
      char c,
      int32 writeCount
    ) cil managed
  {
    .maxstack 3
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    IL_0001: br.s         IL_000c
    // start of loop, entry point: IL_000c
      IL_0003: nop

      // [36 9 - 36 25]
      IL_0004: ldarg.0      // c
      IL_0005: call         void [System.Console]System.Console::Write(char)
      IL_000a: nop
      IL_000b: nop

      // [35 7 - 35 32]
      IL_000c: ldc.i4.0
      IL_000d: ldarg.1      // writeCount
      IL_000e: ldc.i4.1
      IL_000f: sub
      IL_0010: dup

      IL_0011: starg.s      writeCount
      IL_0013: cgt
      IL_0015: ldc.i4.0
      IL_0016: ceq
      IL_0018: stloc.0      // V_0
      IL_0019: ldloc.0      // V_0
      IL_001a: brtrue.s     IL_0003
    // end of loop
    IL_001c: ret

  } // end of method Program::Iterator

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [System.Runtime]System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret

  } // end of method Program::.ctor
} // end of class _01_Mario.Program
