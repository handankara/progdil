using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectNames
{
	public class RollingNames
	{
		public string language;
		public int againcount;
		public List<string> produced = new List<string> ();
		public Dictionary<string, Dictionary<string, List<string>>> 
			treasure = new Dictionary<string, Dictionary<string, List<string>>> () {
			{"tr", new Dictionary<string, List<string>> ()
				{
					{"adjectives", new List<string>
						{"büyük",
						"çekici",
						"çirkin",
						"düz",
						"geniş",
						"güzel",
						"karanlık",
						"kısa",
						"küçük",
						"puslu",
						"şişman",
						"temiz",
						"uzun",
						"yuvarlak",
						"yüksek"
						}
					},
					{"names", new List<string>
						{"anahtarlık",
						"balon",
						"buz",
						"cirit",
						"dantel",
						"deodorant",
						"el arabası",
						"fermuar",
						"hokey",
						"jel",
						"mum",
						"örs",
						"peri",
						"radyo",
						"resim",
						"silgi",
						"termometre",
						"tırnak",
						"tokmak",
						"vazo",
						"yorgan",
						"zımpara"
						}
					}
				}
			},
			{"en", new Dictionary<string, List<string>> ()
				{
					{"adjectives", new List<string>
						{"attractive",
						"beatiful",
						"clean",
						"dark",
						"fat",
						"great",
						"high",
						"little",
						"misty",
						"plain",
						"round",
						"short",
						"tall",
						"ugly",
						"wide"
						}
					},
					{"names", new List<string>
						{"anvil",
						"balloon",
						"candle",
						"deodorant",
						"eraser",
						"fairy",
						"gel",
						"hockey",
						"ice",
						"javelin",
						"keychain",
						"lace",
						"mallet",
						"nail",
						"picture",
						"quilt",
						"radio",
						"sandpaper",
						"thermometer",
						"vase",
						"wheelbarrow",
						"zipper"
						}
					}
				}
			}
		};
		/*		public RollingNames ()
		{
		Nesneyi argüman vermeden de oluşturabilmek için beni etkinleştir.
		}*/
		public RollingNames (string language, int againcount) //Construction method
		{
			this.language = language;
			this.againcount = againcount;
			this.produced = this.ProjectNamerator (this.language, this.againcount);
		}

		public List<string> ProjectNamerator (string language, int againcount)
		{
			List<string> produced = new List<string> ();
			List<string> directorynames = GetDirectoryNames (Directory.GetCurrentDirectory () + 
				Path.DirectorySeparatorChar.ToString () + this.language + "Projects");
			int i = 0;
			Random rnd = new Random ();

			while (i < againcount) {
				string adjective = treasure [language] ["adjectives"] [rnd.Next (0, treasure [language] ["adjectives"].Count)].ToString ();
				string name = treasure [language] ["names"] [rnd.Next (0, treasure [language] ["names"].Count)].ToString ();
				if (directorynames.BinarySearch (adjective + "-" + name) <= -1 &&
					produced.BinarySearch (adjective + "-" + name) <= -1) {
					produced.Add (adjective + "-" + name);
					CreateDirectory (adjective + "-" + name);
					i++;
				}
			}
			return produced;
		}

		public void CreateDirectory (string directoryname)
		{
			Directory.CreateDirectory (Directory.GetCurrentDirectory () +
				Path.DirectorySeparatorChar + this.language + "Projects" + 
				Path.DirectorySeparatorChar + directoryname);
		}

		public List<string> GetDirectoryNames (string path)
		{
			List<string> directorynames = new List<string> ();
			string[] dirs = Directory.GetDirectories (path);
			foreach (string dir in dirs) {
				DirectoryInfo dirInfo = new DirectoryInfo (dir);
				directorynames.Add (dirInfo.Name);
			}
			return directorynames;
		}
	}
}