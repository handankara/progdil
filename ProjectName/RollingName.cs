using System;
using System.Collections.Generic;

namespace ProjectName
{
		public class RollingName
		{
			public string language;
			public int tekrar;
			public Dictionary<string, Dictionary<string, List<string>>> 
			sozluk = new Dictionary<string, Dictionary<string, List<string>>>()
			{
				{"tr" , new Dictionary<string, List<string>>()
					{
						{"adjectives" , new List<string>
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
						{"names" , new List<string>
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
				} ,
				{"en" , new Dictionary<string, List<string>>()
					{
						{"adjectives" , new List<string>
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
						} ,
						{"names" , new List<string>
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
	
	//		static void Main(string[] args)
	//		{
	//		}
	
//			public RollingName ()
//			{
//			}
	
			public RollingName (string lang , int yine)
			{
				this.language = lang;
				this.tekrar = yine;
				this.ProjectNamerator (this.language , this.tekrar);
	
			}
			public void ProjectNamerator(string language , int tekrar)
			{
				
	
				int i = 0;
				while (i < tekrar) 
				{
					i++;
				}
			}
		}
}