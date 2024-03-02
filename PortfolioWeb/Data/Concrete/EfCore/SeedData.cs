using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;
using PortfolioWeb.Data.Concrete;
using PortfolioWeb.Entity;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<PortfolioContext>(); // <== DI>
            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate(); // <== EF
                }

                if (!context.Tags.Any())
                                {
                                    context.Tags.AddRange(
                                    new Tag { Text = "Web Programlama" },
                                    new Tag { Text = "Backend" },
                                    new Tag { Text = "Frontend" },
                                    new Tag { Text = "fullStack" },
                                    new Tag { Text = "Php" }


                                );
                                    context.SaveChanges();
                                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "Ne yapıyorum?",
                            context = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            IsActive = true,
                            Tags = context.Tags.Take(3).ToList(),


                        }
                    );
                    context.Posts.AddRange(
                            new Post
                            {
                                Title = "LINQ'in Avantajları",
                                context = "Kolaylık: LINQ, C# koduna kolaylıkla entegre edilebilir. Bu sayede veri işleme işlemleri kod yazarken daha kolay bir şekilde gerçekleştirilebilir." +
                                "Hız: LINQ, veri tabanı sorgularını ve işlemlerini daha hızlı bir şekilde gerçekleştirir. Bu sayede programların performansı artar." +
                                "Daha az hata: LINQ sayesinde, veri işleme işlemleri sırasında daha az hata yaparsınız. Bu sayede kodlarınız daha düzgün ve hatasız bir şekilde çalışır." +
                                "Okunabilirlik: LINQ, kodların daha okunaklı ve anlaşılır olmasını sağlar. Bu sayede kodların bakımı daha kolay olur.",
                                PublishedOn = DateTime.Now.AddDays(-5),
                                IsActive = true,
                                Tags = context.Tags.Take(4).ToList(),


                            }
                 );

                    context.SaveChanges();
                }
               

                if (!context.References. Any())
                {
                    context.References.AddRange(
                       new IReference
                       {
                           Name = "İsa Bahat",
                           Job = "Software Developer",
                           Title = "Mert'e referansım çünkü;",
                           Text = "O çok hırslıdır ve Azimlidir.Ona güvenin ve işini yapmasını izleyin !",
                           LinkedInAdress = "www.google.com.tr"
                       }
                   );
                    context.SaveChanges();
                }


            }


        }
    }
}