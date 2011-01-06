using System.Collections.Generic;
using System.Linq;

namespace TekpubBrowser
{
	public class Production
	{
		public string title { get; set; }
		public string description { get; set; }
		public List<Episode> episodes { get; set; }
		public string slug { get; set; }

		public string EpisodeCount
		{
			get { return Pluralize(episodes.Count, "episode"); }
		}

		public string TotalDuration
		{
			get
			{
				var d = episodes.Sum(x => x.duration);
				return d > 60
					? Pluralize(d / 60, "hour") + ", " + Pluralize(d - (d / 60) * 60, "minute")
					: Pluralize(d, "minute");
			}
		}

		string Pluralize(int count, string root)
		{
			return count > 1
				? count + " " + root + "s"
				: count + " " + root;
		}

		public string ImageSource
		{
			get
			{
				return string.Format("http://tekpub.com/images/{0}_thumb.png", slug);
			}
		}
	}
}
