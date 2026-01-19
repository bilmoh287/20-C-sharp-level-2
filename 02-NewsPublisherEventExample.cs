using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temprature_Change_Event_Example
{
    public class _02_NewsPublisherEventExample
    {
        public class NewsArtcle
        {
            public string News { get; }
            public string Content { get; }

            public NewsArtcle(string News, string Content)
            {
                this.News = News;
                this.Content = Content;
            }
        }

        public class NewsPublisher
        {
            public event EventHandler<NewsArtcle> NewsPublished;

            public void PublishNews(string News, string Content)
            {
                OnNewNewsPublished(new NewsArtcle(News, Content));
            }

            protected virtual void OnNewNewsPublished(NewsArtcle Artcle)
            {
                NewsPublished?.Invoke(this, Artcle);
            }
        }

        public class NewsSubscriber
        {
            string Name { get; }
            public NewsSubscriber(string Name)
            { this.Name = Name; }

            public void Subscribe(NewsPublisher Publisher)
            {
                Publisher.NewsPublished += HandleNewNews;
            }
            public void UnSubscribe(NewsPublisher Publisher)
            {
                Publisher.NewsPublished -= HandleNewNews;
            }
            public void HandleNewNews(object sender, NewsArtcle Article)
            {
                Console.WriteLine($"{Name} Recieved a New News Article!");
                Console.WriteLine($"Title   : {Article.News}");
                Console.WriteLine($"Content : {Article.Content}");
                Console.WriteLine();
            }
        }

        public class program
        {
            static void Main()
            {
                //Console.WriteLine("Hello");
                NewsPublisher Publisher = new NewsPublisher();

                NewsSubscriber Subscriber1 = new NewsSubscriber("Subscriber1");
                // subscriber 1 subscribes for the publisher
                Subscriber1.Subscribe(Publisher);

                NewsSubscriber Subscriber2 = new NewsSubscriber("Subscriber2");
                // subscriber 1 subscribes for the publisher
                Subscriber2.Subscribe(Publisher);

                Publisher.PublishNews("Breaking News", "Palstine set Free!");
                Publisher.PublishNews("Sport", "Barca won the Chamions League");

                // subscriber 1 Unsubscribes from the publisher
                Subscriber1.UnSubscribe(Publisher);
                Publisher.PublishNews("Weather Forcast", "Expect sunny wather for the weekend");

                // subscriber 1 Unsubscribes from the publisher
                Subscriber2.UnSubscribe(Publisher);
                Publisher.PublishNews("Entertainment", "The Weekend droped new Album");

                // subscriber 1 Subscribes Again
                Subscriber1.Subscribe(Publisher);
                Publisher.PublishNews("Entertainment", "Deamon Slayer Movie Part 2 has been released");
            }
        }

    }
}
