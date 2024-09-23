using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Files.Classes
{
    internal class ComponentList
    {
        
        internal Dictionary<string, List<string>> ram;
        internal Dictionary<string, List<string>> keyboards;
        internal Dictionary<string, List<string>> ssds;
        internal Dictionary<string, List<string>> processors;
        internal Dictionary<string, List<string>> monitors;
        internal Dictionary<string, List<string>> motherboards;
        internal Dictionary<string, List<string>> mouse;
        internal Dictionary<string, List<string>> gpus;
        internal ComponentList() 
        {
            
            this.Proccessor();
            this.RAM();
            this.Keyboard();
            this.SSD();
            this.Monitor();
            this.MotherBoard();
            this.Mouse();   
            this.GPU();
        }

        internal void Proccessor()
        {
         processors = new Dictionary<string, List<string>>
          {
            { "AMD", new List<string>
                {
                    "Ryzen 9 7950X",
                    "Ryzen 9 7900X",
                    "Ryzen 9 5950X",
                    "Ryzen 9 5900X",
                    "Ryzen 7 5800X",
                    "Ryzen 7 5700G",
                    "Ryzen 7 5800G",
                    "Ryzen 7 5800X3D",
                    "Ryzen 5 5600X",
                    "Ryzen 5 5600G",
                    "Ryzen 5 5500",
                    "Ryzen 5 3400G",
                    "Ryzen 5 2400G",
                    "Ryzen 3 5300G",
                    "Ryzen 3 4100",
                    "Ryzen 3 3200G",
                    "Ryzen 3 2200G",
                    "Athlon 3000G",
                    "Athlon 200GE",
                    "Ryzen Threadripper 3990X",
                    "Ryzen Threadripper 3970X",
                    "Ryzen Threadripper 3960X",
                    "Ryzen Threadripper PRO 5995WX",
                    "Ryzen Threadripper PRO 5975WX",
                    "Ryzen Threadripper PRO 5945WX"
                }
            },
            { "Intel", new List<string>
                {
                    "Core i9-13900K",
                    "Core i9-13900KF",
                    "Core i9-13900KS",
                    "Core i9-12900K",
                    "Core i9-12900KF",
                    "Core i7-13700K",
                    "Core i7-13700KF",
                    "Core i7-12700K",
                    "Core i7-12700KF",
                    "Core i5-12600K",
                    "Core i5-12600KF",
                    "Core i5-12400",
                    "Core i5-12400F",
                    "Core i3-12100",
                    "Core i3-12100F",
                    "Pentium Gold G6400",
                    "Pentium Gold G6500",
                    "Celeron G5900",
                    "Celeron G6800",
                    "Xeon W-3300",
                    "Xeon Scalable Gen 3",
                    "Core i9-11900K",
                    "Core i9-11900KF",
                    "Core i7-11700K",
                    "Core i7-11700KF",
                    "Core i5-11600K",
                    "Core i5-11600KF",
                    "Core i3-11100",
                    "Core i3-10100",
                    "Core i7-10700K",
                    "Core i7-10700KF",
                    "Core i5-10400",
                    "Core i5-10400F"
                }
            }
        };
     }    
        internal void RAM()
        {

          ram = new Dictionary<string, List<string>>()
            {
                { "Corsair", new List<string> { "Vengeance LPX", "Dominator Platinum RGB", "Vengeance RGB Pro" } },
                { "G.Skill", new List<string> { "Trident Z RGB", "Ripjaws V", "Trident Z Neo" } },
                { "Kingston", new List<string> { "FURY Beast", "FURY Renegade", "HyperX Predator" } },
                { "Crucial", new List<string> { "Ballistix", "Crucial DDR4", "Crucial DDR5" } },
                { "Team Group", new List<string> { "T-Force Xtreem ARGB", "T-Force Vulcan Z", "T-Force Delta RGB" } },
                { "ADATA", new List<string> { "XPG Spectrix D50", "XPG Hunter", "XPG Gammix D30" } },
                { "Patriot", new List<string> { "Viper Steel", "Viper RGB", "Viper Elite II" } },
                { "Samsung", new List<string> { "Samsung DDR4", "Samsung DDR5", "Samsung DDR3" } }
            };




        }
        internal void Keyboard()
       {
             keyboards = new Dictionary<string, List<string>>
         {
            { "Logitech", new List<string> { "K800", "K120" } },
            { "Keychron", new List<string> { "Keychron K2" } },
            { "Razer", new List<string> { "Razer Huntsman" } },
            { "Corsair", new List<string> { "Corsair K95" } },
            { "Das Keyboard", new List<string> { "Das Keyboard 4" } },
            { "Ducky", new List<string> { "Ducky One 2 Mini" } },
            { "SteelSeries", new List<string> { "SteelSeries Apex Pro" } },
            { "HyperX", new List<string> { "HyperX Alloy FPS Pro" } },
            { "Apple", new List<string> { "Apple Magic Keyboard" } }
         };

       }        
        internal void SSD()
        {
             ssds = new Dictionary<string, List<string>>
         {
            { "Samsung", new List<string> { "970 EVO", "860 EVO", "980 PRO" } },
            { "Western Digital", new List<string> { "WD Black SN850", "WD Blue SN550" } },
            { "Crucial", new List<string> { "MX500", "P5 Plus" } },
            { "Kingston", new List<string> { "A2000", "KC2500" } },
            { "SanDisk", new List<string> { "Extreme Pro", "Ultra 3D" } },
            { "Intel", new List<string> { "660p", "760p" } },
            { "Seagate", new List<string> { "FireCuda 520", "Barracuda 120" } },
            { "ADATA", new List<string> { "XPG SX8200 Pro", "XPG GAMMIX S5" } },
            { "Toshiba", new List<string> { "OCZ RD400", "TR200" } },
            { "Sabrent", new List<string> { "Rocket Q", "Rocket NVMe" } }
         };
        }
        internal void Monitor()
        {
           monitors = new Dictionary<string, List<string>>
        {
            { "Dell", new List<string>
                {
                    "UltraSharp U2720Q",
                    "P2720DC",
                    "S2721QS",
                    "Alienware AW2521H",
                    "G2722HS"
                }
            },
            { "Samsung", new List<string>
                {
                    "Odyssey G9",
                    "S32R750",
                    "LS27R950Q",
                    "S24F350",
                    "CRG9"
                }
            },
            { "LG", new List<string>
                {
                    "UltraFine 5K",
                    "27UN850-W",
                    "34WN80C-B",
                    "32UN880-B",
                    "27GN950-B"
                }
            },
            { "ASUS", new List<string>
                {
                    "ProArt PA32UCX",
                    "ROG Swift PG32UQ",
                    "TUF Gaming VG259QM",
                    "Designo MX279HE",
                    "VG248QG"
                }
            },
            { "Acer", new List<string>
                {
                    "Predator X27",
                    "XR342CK",
                    "R240HY",
                    "KG271U",
                    "EB321HQU"
                }
            },
            { "BenQ", new List<string>
                {
                    "PD3220U",
                    "SW271C",
                    "GW2480",
                    "EX2780Q",
                    "Mobiuz EX3210R"
                }
            },
            { "ViewSonic", new List<string>
                {
                    "VP2768a-4K",
                    "XG2405",
                    "VX2758-2KP-MHD",
                    "VP3268a-4K",
                    "VP2458"
                }
            },
            { "HP", new List<string>
                {
                    "P27h G4",
                    "X24ih",
                    "Z27",
                    "E27 G4",
                    "M24f"
                }
            },
            { "Philips", new List<string>
                {
                    "275P4VYKEB",
                    "M327P1H",
                    "322E1C",
                    "246E9QDSB",
                    "258B6QUEB"
                }
            },
            { "MSI", new List<string>
                {
                    "Optix MAG272CQR",
                    "Prestige PS341WU",
                    "MAG321CURV",
                    "Optix MPG341CQR",
                    "G241"
                }
            }
        };
        }
        internal void MotherBoard()
        {
          motherboards = new Dictionary<string, List<string>>
          {
            { "ASUS", new List<string>
                {
                    "ROG Crosshair VIII Hero",
                    "TUF Gaming X570-Plus",
                    "Prime Z590-A",
                    "ROG Strix B550-F Gaming",
                    "ProArt Z490-Creator 10G"
                }
            },
            { "MSI", new List<string>
                {
                    "MEG Z490 GODLIKE",
                    "MAG B550M MORTAR",
                    "MPG X570 GAMING EDGE WIFI",
                    "B450 TOMAHAWK MAX",
                    "Creator TRX40"
                }
            },
            { "Gigabyte", new List<string>
                {
                    "AORUS Z490 MASTER",
                    "B550 AORUS ELITE",
                    "Z590 AORUS XTREME",
                    "X570 AORUS ULTRA",
                    "Z490 AORUS PRO AC"
                }
            },
            { "ASRock", new List<string>
                {
                    "X570 Taichi",
                    "B550 Phantom Gaming 4",
                    "Z490 Taichi",
                    "H570 Steel Legend",
                    "X299 Taichi CLX"
                }
            },
            { "EVGA", new List<string>
                {
                    "Z490 DARK",
                    "X299 DARK",
                    "Z390 FTW",
                    "X570 CLASSIFIED",
                    "Z590 FTW"
                }
            },
            { "Biostar", new List<string>
                {
                    "B550GTQ",
                    "X570GT8",
                    "Z490GTN",
                    "B450GT3",
                    "TB360-BTC PRO"
                }
            },
            { "Intel", new List<string>
                {
                    "NUC 9 Extreme Kit",
                    "NUC 11 Performance Kit",
                    "Intel Server Board S2600ST",
                    "D2500CC",
                    "D34010WYK"
                }
            },
            { "HP", new List<string>
                {
                    "ProLiant DL380 Gen10",
                    "ProLiant ML350 Gen10",
                    "ProLiant MicroServer Gen10 Plus",
                    "Z420",
                    "Z440"
                }
            },
            { "Supermicro", new List<string>
                {
                    "X11SPA-T",
                    "X11SPL-F",
                    "X11SPA-B",
                    "X10SRi-F",
                    "X11SPA-T"
                }
            }
        };
        }
        internal void Mouse()
        {
       mouse = new Dictionary<string, List<string>>
        {
            { "Logitech", new List<string>
                {
                    "MX Master 3",
                    "G502 HERO",
                    "G Pro Wireless",
                    "M720 Triathlon",
                    "G305 LIGHTSPEED"
                }
            },
            { "Razer", new List<string>
                {
                    "DeathAdder V2",
                    "Viper Ultimate",
                    "Basilisk V3",
                    "Naga X",
                    "Huntsman Mini"
                }
            },
            { "SteelSeries", new List<string>
                {
                    "Rival 600",
                    "Sensei Ten",
                    "Aerox 3",
                    "Rival 310",
                    "SteelSeries QcK"
                }
            },
            { "Corsair", new List<string>
                {
                    "SCIMITAR RGB ELITE",
                    "M65 RGB ELITE",
                    "Glaive RGB",
                    "Harpoon RGB Wireless",
                    "Sabre RGB PRO"
                }
            },
            { "HyperX", new List<string>
                {
                    "Pulsefire FPS Pro",
                    "Pulsefire Haste",
                    "Pulsefire Dart",
                    "Alloy FPS Pro",
                    "Pulsefire Core"
                }
            },
            { "Zowie", new List<string>
                {
                    "EC1-B",
                    "FK1",
                    "ZA11",
                    "S1",
                    "S2"
                }
            },
            { "Cooler Master", new List<string>
                {
                    "MM711",
                    "MM720",
                    "GM50",
                    "MM520",
                    "MM830"
                }
            },
            { "ASUS", new List<string>
                {
                    "ROG Gladius III",
                    "ROG Spatha X",
                    "ROG Keris Wireless",
                    "TUF Gaming M3",
                    "ROG Chakram"
                }
            },
            { "Roccat", new List<string>
                {
                    "Kone Pure Ultra",
                    "Kone AIMO Remastered",
                    "Taito Control",
                    "Burst Pro",
                    "Kone EMP"
                }
            },
            { "Finalmouse", new List<string>
                {
                    "Starlight-12",
                    "Ultralight Phantom",
                    "Air58",
                    "Ninja Air58",
                    "Cape Town"
                }
            }
        };

        }      
        internal void GPU()
        {
           gpus = new Dictionary<string, List<string>>
         {
            { "NVIDIA", new List<string>
                {
                    "GeForce RTX 4090",
                    "GeForce RTX 4080",
                    "GeForce RTX 4070 Ti",
                    "GeForce RTX 3060 Ti",
                    "GeForce GTX 1660 Super"
                }
            },
            { "AMD", new List<string>
                {
                    "Radeon RX 7900 XTX",
                    "Radeon RX 7900 XT",
                    "Radeon RX 6800 XT",
                    "Radeon RX 6700 XT",
                    "Radeon RX 6500 XT"
                }
            },
            { "Intel", new List<string>
                {
                    "Arc A770",
                    "Arc A750",
                    "Arc A380"
                }
            },
            { "ASUS", new List<string>
                {
                    "ROG Strix GeForce RTX 4090",
                    "TUF Gaming GeForce RTX 3080",
                    "Dual Radeon RX 6700 XT",
                    "ROG Strix Radeon RX 6800 XT"
                }
            },
            { "MSI", new List<string>
                {
                    "GeForce RTX 4090 SUPRIM X",
                    "GeForce RTX 3070 GAMING X",
                    "Radeon RX 6800 XT GAMING X",
                    "GeForce GTX 1660 VENTUS XS"
                }
            },
            { "Gigabyte", new List<string>
                {
                    "AORUS GeForce RTX 4090",
                    "GeForce RTX 3080 GAMING OC",
                    "Radeon RX 6700 XT GAMING OC",
                    "GeForce GTX 1650 WINDFORCE"
                }
            },
            { "EVGA", new List<string>
                {
                    "GeForce RTX 3090 FTW3",
                    "GeForce RTX 3080 XC3",
                    "GeForce GTX 1660 Ti SC Ultra",
                    "GeForce RTX 3070 FTW"
                }
            },
            
        };
        }

        //internal void Print()
        //{
        //    foreach (var series in amdProcessors)
        //    {
        //        Console.WriteLine(series[0] + " Processors:");
        //        for (int i = 1; i < series.Count; i++)
        //        {
        //            Console.WriteLine("  - " + series[i]);
        //        }

        //    }
        //}
    }
}
