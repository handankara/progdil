using System;
using System.Collections.Generic;

namespace ProjectName
{
		public class RollingName
		{
			public string language;
			public int tekrar;
			public List<string> uretilenler = new List<string>();
			public Dictionary<string, Dictionary<string, List<string>>> //Bu sözlük burada olmamalı 
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
	
//			static void Main(string[] args)
//			{
//			}
	
//			public RollingName ()
//			{
//			}
	
			public RollingName (string lang , int yine) //Construction method
			{
				this.language = lang;
				this.tekrar = yine;
				this.uretilenler = this.ProjectNamerator (this.language , this.tekrar); //ProjectNamerator un ürettiği listeyi
			}																			//sınıfın niteliği olan uretilenler e aktardık
			public List<string> ProjectNamerator(string language , int tekrar)			//artık nesne.uretilenler ile oluşturulan isimlere erişilebilir
			{
			//TODO temp listesine değil de projeler dizinine baksın
				List<string> temp = new List<string>();
				int i = 0;
				Random rnd = new Random ();

				while (i < tekrar) 
				{
					string adjective = sozluk [language] ["adjectives"] [rnd.Next (0, sozluk [language] ["adjectives"].Count)].ToString ();
					string name = sozluk [language] ["names"] [rnd.Next (0, sozluk [language] ["names"].Count)].ToString ();
					if ( temp.Contains(adjective + " " + name) == false )
					{
						temp.Add (adjective + " " + name);
						i++;
					}
				}
				return temp;
			}
			
		}
}