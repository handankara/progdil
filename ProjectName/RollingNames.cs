using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectNames
{
	public class RollingNames
	{
		private string language = System.Globalization.CultureInfo.CurrentCulture.Name.Split ('-') [0];
		private int againcount = 1;
		public List<string> produced = new List<string> ();
		private Dictionary<string, Dictionary<string, List<string>>> 
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

		public RollingNames ()
		{
		}

		public RollingNames (string language, int againcount) // Construction method
		{
			this.language = language;
			this.againcount = againcount;
		}

		public void ProjectNamerator ()
		{
			List<string> directorynames = GetDirectoryNames (Directory.GetCurrentDirectory () + 
				Path.DirectorySeparatorChar.ToString () + this.language + "Projects");
			int i = 0;
			Random rnd = new Random ();

			while (i < this.againcount) {
				string adjective = treasure [this.language] ["adjectives"] [rnd.Next (0, treasure [this.language] ["adjectives"].Count)].ToString ();
				string name = treasure [this.language] ["names"] [rnd.Next (0, treasure [this.language] ["names"].Count)].ToString ();
				if (this.produced.Contains (adjective + "-" + name) ||
					directorynames.Contains (adjective + "-" + name)) {
					// noop
				} else {
					this.produced.Add (adjective + "-" + name);
					i++;
				}
			}
			CreateDirectories (this.produced);
		}

		public void CreateDirectories (List<string> directorynames)
		{
			foreach (string directoryname in directorynames) {
				Directory.CreateDirectory (Directory.GetCurrentDirectory () +
					Path.DirectorySeparatorChar + this.language + "Projects" + 
					Path.DirectorySeparatorChar + directoryname);
			}
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