using ProfinetHaberlesme;
using S7.Net;
using S7.Net.Types;
using System.Timers;
using System;

public class Program
{
    private System.Timers.Timer _timer = null;
    public static void Main()
    {

        int timerInterval = 1000;

        // Create a timer with a two second interval.
        var aTimer = new System.Timers.Timer(timerInterval);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;

        // Wait for the user to hit <Enter>
        Console.ReadLine();
    }
    static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("Timer: " + e.SignalTime.ToLongTimeString());
        Connect();
    }

    static void Connect()
    {
        try
        {
            using (var plc = new Plc(CpuType.S71200, "192.168.0.1", 0, 1))
            {
                plc.Open();

                // 1: example on how to read variables one by one by specifing the absolute address
                //ReadSingleVariables(plc);
                //ReadMultipleVars(plc);

                Console.WriteLine("\nPress a key to continue...");
                // 2: example on how to read block of bytes + conversions
                ReadBytes(plc);

                // 3: example on how to read classes 
                //ReadClasses(plc);

                // 4: example on how to read multiple block of bytes in a single request
                //ReadMultipleVars(plc);

                // 5: clears the db values by writing two array bytes full of 0
                //ClearDbValues(plc);

                // 6: example on how to write varbiables one by one by specifing the absolute address
                //WriteSingleVariable(plc);

                // 7: example on how to write block of bytes 
                //WriteBytes(plc);
            }

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }



    public static void ReadBytes(Plc plc)
    {
        Console.WriteLine("\n--- DB 1 ---\n");

        var db1Bytes = plc.ReadBytes(DataType.DataBlock, 12, 0, 254);

        //Vertical_Displacement BOOL

        bool db1Bool1 = db1Bytes[0].SelectBit(0);
        Console.WriteLine("DB1.DBX0.0: " + db1Bool1);

        bool db1Bool2 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool2);

        bool db1Bool3 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool3);

        bool db1Bool4 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool4);

        bool db1Bool5 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool5);

        bool db1Bool6 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool6);

        bool db1Bool7 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool7);

        bool db1Bool8 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool8);

        bool db1Bool9 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool9);

        bool db1Bool10 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool10);

        bool db1Bool11 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool11);

        bool db1Bool12 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool12);

        bool db1Bool13 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool13);

        bool db1Bool14 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool14);

        bool db1Bool15 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool15);

        bool db1Bool16 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool16);

        bool db1Bool17 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool17);

        //Distance Between Characters BOOL

        bool db1Bool18 = db1Bytes[0].SelectBit(0);
        Console.WriteLine("DB1.DBX0.0: " + db1Bool18);

        bool db1Bool19 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool19);

        bool db1Bool20 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool20);

        bool db1Bool21 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool21);

        bool db1Bool22 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool22);

        bool db1Bool23 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool23);

        bool db1Bool24 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool24);

        bool db1Bool25 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool25);

        bool db1Bool26 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool26);

        bool db1Bool27 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool27);

        bool db1Bool28 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool28);

        bool db1Bool29 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool29);

        bool db1Bool30 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool30);

        bool db1Bool31 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool31);

        bool db1Bool32 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool32);

        bool db1Bool33 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool33);

        bool db1Bool34 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool34);

        //Inc_Scribed/Stamped _Number BOOL

        bool db1Bool35 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool35);

        //Inc_individual BOOL

        bool db1Bool36 = db1Bytes[0].SelectBit(0);
        Console.WriteLine("DB1.DBX0.0: " + db1Bool36);

        bool db1Bool37 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool37);

        bool db1Bool38 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool38);

        bool db1Bool39 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool39);

        bool db1Bool40 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool40);

        bool db1Bool41 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool41);

        bool db1Bool42 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool42);

        bool db1Bool43 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool43);

        bool db1Bool44 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool44);

        bool db1Bool45 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool45);

        bool db1Bool46 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool46);

        bool db1Bool47 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool47);

        bool db1Bool48 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool48);

        bool db1Bool49 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool49);

        bool db1Bool50 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool50);

        bool db1Bool51 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool51);

        bool db1Bool52 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool52);

        //No_damage BOOL

        bool db1Bool53 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool53);

        //Depth Check BOOL

        bool db1Bool54 = db1Bytes[0].SelectBit(0);
        Console.WriteLine("DB1.DBX0.0: " + db1Bool54);

        bool db1Bool55 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool55);

        bool db1Bool56 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool56);

        bool db1Bool57 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool57);

        bool db1Bool58 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool58);

        bool db1Bool59 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool59);

        bool db1Bool60 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool60);

        bool db1Bool61 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool61);

        bool db1Bool62 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool62);

        bool db1Bool63 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool63);

        bool db1Bool64 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool64);

        bool db1Bool65 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool65);

        bool db1Bool66 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool66);

        bool db1Bool67 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool67);

        bool db1Bool68 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool68);

        bool db1Bool69 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool69);

        bool db1Bool70 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool70);

        //Ovaral Result BOOL

        bool db1Bool71 = db1Bytes[0].SelectBit(1);
        Console.WriteLine("DB1.DBX0.1: " + db1Bool71);

        //CHAR

        string dbChar1 = S7.Net.Types.String.FromByteArray(db1Bytes.Skip(22).Take(17).ToArray());
        Console.WriteLine("DB1.DBW18.0: " + dbChar1);

        //Vertical Displacement Measurement REAL

        double db1RealVariable1 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(40).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable1);

        double db1RealVariable2 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(44).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable2);

        double db1RealVariable3 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(48).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable3);

        double db1RealVariable4 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(52).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable4);

        double db1RealVariable5 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(56).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable5);

        double db1RealVariable6 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(60).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable6);

        double db1RealVariable7 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(64).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable7);

        double db1RealVariable8 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(68).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable8);

        double db1RealVariable9 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(72).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable9);

        double db1RealVariable10 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(76).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable10);

        double db1RealVariable11 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(80).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable11);

        double db1RealVariable12 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(84).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable12);

        double db1RealVariable13 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(88).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable13);

        double db1RealVariable14 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(92).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable14);

        double db1RealVariable15 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(96).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable15);

        double db1RealVariable16 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(100).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable16);


        double db1RealVariable17 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(104).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable17);


        //Distance_Between_Characters_Measurement REAL

        double db1RealVariable18 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(108).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable18);

        double db1RealVariable19 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(112).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable19);

        double db1RealVariable20 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(116).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable20);

        double db1RealVariable21 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(120).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable21);

        double db1RealVariable22 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(124).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable5);

        double db1RealVariable23 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(128).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable23);

        double db1RealVariable24 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(132).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable24);

        double db1RealVariable25 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(136).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable25);

        double db1RealVariable26 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(140).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable26);

        double db1RealVariable27 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(144).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable27);

        double db1RealVariable28 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(148).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable28);

        double db1RealVariable29 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(152).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable29);

        double db1RealVariable30 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(156).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable30);

        double db1RealVariable31 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(160).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable31);

        double db1RealVariable32 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(164).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable32);

        double db1RealVariable33 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(168).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable33);

        double db1RealVariable34 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(172).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable34);


        // Inc_Scribed/Stamped _Number_Measurement REAL

        double db1RealVariable35 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(176).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable35);

        //Inc_individual_Measurement REAL

        double db1RealVariable36 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(180).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable36);

        double db1RealVariable37 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(184).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable37);

        double db1RealVariable38 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(188).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable38);

        double db1RealVariable39 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(192).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable39);

        double db1RealVariable40 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(196).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable40);

        double db1RealVariable41 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(200).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable41);

        double db1RealVariable42 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(204).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable42);

        double db1RealVariable43 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(208).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable43);

        double db1RealVariable44 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(212).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable44);

        double db1RealVariable45 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(216).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable45);

        double db1RealVariable46 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(220).Take(4).ToArray());
        Console.WriteLine("DB12.DBD216.0: " + db1RealVariable46);

        double db1RealVariable47 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(224).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable47);

        double db1RealVariable48 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(228).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable48);

        double db1RealVariable49 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(232).Take(4).ToArray());
        Console.WriteLine("DB1.DBD4.0: " + db1RealVariable49);

        double db1RealVariable50 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(236).Take(4).ToArray());
        Console.WriteLine("Inc_individual_Measurement15: " + db1RealVariable50);

        double db1RealVariable51 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(240).Take(4).ToArray());
        Console.WriteLine("Inc_individual_Measurement16: " + db1RealVariable51);

        double db1RealVariable52 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(244).Take(4).ToArray());
        Console.WriteLine("Inc_individual_Measurement17: " + db1RealVariable52);

        //Score REAL

        double db3RealVariable1 = S7.Net.Types.Double.FromByteArray(db1Bytes.Skip(248).Take(4).ToArray());
        Console.WriteLine("Score: " + db3RealVariable1);

        //Char Count INT

        short CharCount = S7.Net.Types.Int.FromByteArray(db1Bytes.Skip(252).Take(2).ToArray());
        Console.WriteLine("Char Count: " + CharCount);       
    }

    private static void WriteBytes(Plc plc)
    {
        Console.WriteLine("\n--- DB 1 ---\n");

        byte[] db1Bytes = new byte[18];

        S7.Net.Types.Boolean.SetBit(db1Bytes[0], 0); // DB1.DBX0.0

        S7.Net.Types.Boolean.SetBit(db1Bytes[0], 1); // DB1.DBX0.1

        short db1IntVariable = 50;
        S7.Net.Types.Int.ToByteArray(db1IntVariable).CopyTo(db1Bytes, 2); // DB1.DBW2.0


        double db1RealVariable = 25.36;
        S7.Net.Types.Double.ToByteArray(db1RealVariable).CopyTo(db1Bytes, 4); // DB3.DBD4.0


        int db1DintVariable = 123456;
        S7.Net.Types.DInt.ToByteArray(db1DintVariable).CopyTo(db1Bytes, 8); // DB1.DBD8.0


        uint db1DwordVariable = 123456;
        S7.Net.Types.DWord.ToByteArray(db1DwordVariable).CopyTo(db1Bytes, 12); // DB1.DBD12.0


        ushort db1WordVariable = 12345;
        S7.Net.Types.Word.ToByteArray(db1WordVariable).CopyTo(db1Bytes, 16); // DB1.DBD16.0

        plc.WriteBytes(DataType.DataBlock, 1, 0, db1Bytes);


        Console.WriteLine("\n--- DB 3 ---\n");

        byte[] db3Bytes = new byte[18];

        S7.Net.Types.Boolean.SetBit(db3Bytes[0], 0); // DB3.DBX0.0

        S7.Net.Types.Boolean.SetBit(db3Bytes[0], 1); // DB3.DBX0.1


        short db3IntVariable = -50;
        S7.Net.Types.Int.ToByteArray(db3IntVariable).CopyTo(db3Bytes, 2); // DB3.DBW2.0


        double db3RealVariable = -25.36;
        S7.Net.Types.Double.ToByteArray(db3RealVariable).CopyTo(db3Bytes, 4); // DB3.DBD4.0


        int db3DintVariable = -123456;
        S7.Net.Types.DInt.ToByteArray(db3DintVariable).CopyTo(db3Bytes, 8); // DB3.DBD8.0


        int db3DwordVariable = -123456;
        S7.Net.Types.DWord.ToByteArray(db3DwordVariable.ConvertToUInt()).CopyTo(db3Bytes, 12); // DB3.DBD12.0


        short db3WordVariable = -1234;
        S7.Net.Types.Word.ToByteArray(db3WordVariable.ConvertToUshort()).CopyTo(db3Bytes, 16); // DB3.DBD16.0

        plc.WriteBytes(DataType.DataBlock, 3, 0, db3Bytes);
    }

}



