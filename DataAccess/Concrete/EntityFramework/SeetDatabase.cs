using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class SeetDatabase
    {
        public static void Seed()
        {
            var context = new MovieContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.ContentTypes.Count() == 0)
                {
                    context.ContentTypes.AddRange(ContentTypes);
                    context.AddRange();
                }
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                    context.AddRange(CategoryLanguages);
                }
                if (context.Contents.Count() == 0)
                {
                    context.Contents.AddRange(Contents);
                    context.AddRange(Languages);
                    context.AddRange(ContentCategories);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories =
        {
            new Category() { CategorySeo = "Action"},
            new Category() { CategorySeo = "Comedy"},
            new Category() { CategorySeo = "Drama"},
            new Category() { CategorySeo = "Fantasy"},
            new Category() { CategorySeo = "Horror"},
            new Category() { CategorySeo = "Mystery"},
            new Category() { CategorySeo = "Romance"},
            new Category() { CategorySeo = "Thriller"},
        };

        private static ContentType[] ContentTypes =
        {
            new ContentType() { Name = "Film"},   
            new ContentType() { Name = "Serial"},
            new ContentType() { Name = "CinemaLab"}
        };

        private static CategoryLanguage[] CategoryLanguages =
        {
            new CategoryLanguage() { CategoryName = "Aksion", LangCode="Az", Category = Categories[0]},
            new CategoryLanguage() { CategoryName = "Aksiyon", LangCode="Tr", Category = Categories[0]},
            new CategoryLanguage() { CategoryName = "Боевики", LangCode="Ru", Category = Categories[0]},
            new CategoryLanguage() { CategoryName = "Action", LangCode="Eng", Category = Categories[0]},
            new CategoryLanguage() { CategoryName = "Komediya", LangCode="Az", Category = Categories[1]},
            new CategoryLanguage() { CategoryName = "Komedi", LangCode="Tr", Category = Categories[1]},
            new CategoryLanguage() { CategoryName = "Комедия", LangCode="Ru", Category = Categories[1]},
            new CategoryLanguage() { CategoryName = "Comedy", LangCode="Eng", Category = Categories[1]},
            new CategoryLanguage() { CategoryName = "Drama", LangCode="Az", Category = Categories[2]},
            new CategoryLanguage() { CategoryName = "Dram", LangCode="Tr", Category = Categories[2]},
            new CategoryLanguage() { CategoryName = "Драма", LangCode="Ru", Category = Categories[2]},
            new CategoryLanguage() { CategoryName = "Drama", LangCode="Eng", Category = Categories[2]},
            new CategoryLanguage() { CategoryName = "Fantaziya", LangCode="Az", Category = Categories[3]},
            new CategoryLanguage() { CategoryName = "Fantezi", LangCode="Tr", Category = Categories[3]},
            new CategoryLanguage() { CategoryName = "Фантазия", LangCode="Ru", Category = Categories[3]},
            new CategoryLanguage() { CategoryName = "Fantasy", LangCode="Eng", Category = Categories[3]},
            new CategoryLanguage() { CategoryName = "Qorxu", LangCode="Az", Category = Categories[4]},
            new CategoryLanguage() { CategoryName = "Korku", LangCode="Tr", Category = Categories[4]},
            new CategoryLanguage() { CategoryName = "Фильм ужасов", LangCode="Ru", Category = Categories[4]},
            new CategoryLanguage() { CategoryName = "Horror", LangCode="Eng", Category = Categories[4]},
            new CategoryLanguage() { CategoryName = "Sirr", LangCode="Az", Category = Categories[5]},
            new CategoryLanguage() { CategoryName = "Gizem", LangCode="Tr", Category = Categories[5]},
            new CategoryLanguage() { CategoryName = "Тайна", LangCode="Ru", Category = Categories[5]},
            new CategoryLanguage() { CategoryName = "Mystery", LangCode="Eng", Category = Categories[5]},
            new CategoryLanguage() { CategoryName = "Romantika", LangCode="Az", Category = Categories[6]},
            new CategoryLanguage() { CategoryName = "Romantik", LangCode="Tr", Category = Categories[6]},
            new CategoryLanguage() { CategoryName = "Романтика", LangCode="Ru", Category = Categories[6]},
            new CategoryLanguage() { CategoryName = "Romance", LangCode="Eng", Category = Categories[6]},
            new CategoryLanguage() { CategoryName = "Triller", LangCode="Az", Category = Categories[7]},
            new CategoryLanguage() { CategoryName = "Gerilim", LangCode="Tr", Category = Categories[7]},
            new CategoryLanguage() { CategoryName = "Триллер", LangCode="Ru", Category = Categories[7]},
            new CategoryLanguage() { CategoryName = "Thriller", LangCode="Eng", Category = Categories[7]},
        };


        private static Content[] Contents = {
            new Content() { MainPicture = "as", Age = "8",ContentDate = DateTime.Now, AddDate = DateTime.Now, IsFree = true, Hit = 0,ModifiedOn = DateTime.Now, ContentType = ContentTypes[0]},
            new Content() { MainPicture = "as", Age = "8",ContentDate = DateTime.Now, AddDate = DateTime.Now, IsFree = true, Hit = 0,ModifiedOn = DateTime.Now, ContentType = ContentTypes[1]},
            new Content() { MainPicture = "as", Age = "8",ContentDate = DateTime.Now, AddDate = DateTime.Now, IsFree = true, Hit = 0,ModifiedOn = DateTime.Now, ContentType = ContentTypes[2]},

        };

        private static ContentLanguage[] Languages = { 
            new ContentLanguage() { Name = "The Shawshank Redemption", Description="Həbsdə olan iki kişi bir neçə il ərzində bir-birini bağlayır, ümumi ədəb-ərkan hərəkətləri ilə təsəlli tapır və nəticədə xilas olur.",LangCode = "Az",Content =  Contents[0]},
            new ContentLanguage() { Name = "Esaretin Bedeli", Description="Hapsedilmiş iki adam, birkaç yıl boyunca birbirlerine bağlanarak, teselliyi ve sonunda ortak nezaket eylemleriyle kurtuluşu bulurlar.",LangCode = "Tr",Content =  Contents[0]},
            new ContentLanguage() { Name = "The Shawshank Redemption", Description="Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",LangCode = "Eng",Content =  Contents[0]},
            new ContentLanguage() { Name = "Побег из Шоушенка", Description="Двое заключенных связаны друг с другом в течение нескольких лет, находя утешение и в конечном итоге искупление через действия общей приличия.",LangCode = "Ru",Content =  Contents[0]},
            new ContentLanguage() { Name = "Xaç atası", Description="Xaç atası, Korleone ailəsindən olan Don Vito Korleonenin ardınca, mantelini istəməyən oğlu Mayklın yanına keçir.",LangCode = "Az",Content =  Contents[1]},
            new ContentLanguage() { Name = "Baba", Description="Vaftiz babası, şömineyi isteksiz oğlu Michael'a verirken Corleone ailesinden Don Vito Corleone'yi takip eder.",LangCode = "Tr",Content =  Contents[1]},
            new ContentLanguage() { Name = "The Godfather", Description="The Godfather follows Vito Corleone, Don of the Corleone family, as he passes the mantel to his unwilling son, Michael.",LangCode = "Eng",Content =  Contents[1]},
            new ContentLanguage() { Name = "Крестный отец", Description="Крестный отец следует за Вито Корлеоне, Доном из семьи Корлеоне, когда он передает камин своему невольному сыну Майклу.",LangCode = "Ru",Content =  Contents[1]},
            new ContentLanguage() { Name = "Inception", Description="Xəyalların bölüşdürülməsi texnologiyasından istifadə edərək korporativ sirləri oğurlayan oğruya C.E.O.-nun beyninə ideya yerləşdirmək kimi tərs vəzifə verilir, lakin onun faciəli keçmişi layihəni və onun komandasını fəlakətə məhkum edə bilər.",LangCode = "Az",Content =  Contents[2]},
            new ContentLanguage() { Name = "Başlangıç", Description="Rüya paylaşımı teknolojisini kullanarak kurumsal sırları çalan bir hırsıza, bir fikri CEO'nun zihnine yerleştirme görevi verilir, ancak trajik geçmişi projeyi ve ekibini felakete mahkûm edebilir.",LangCode = "Tr",Content =  Contents[2]},
            new ContentLanguage() { Name = "Inception", Description="A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",LangCode = "Eng",Content =  Contents[2]},
            new ContentLanguage() { Name = "Зарождение", Description="Вору, который крадет корпоративные секреты с помощью технологии обмена сновидениями, дается обратная задача - внедрить идею в сознание генерального директора, но его трагическое прошлое может обречь проект и его команду на катастрофу.",LangCode = "Ru",Content =  Contents[2]}
        };

        private static ContentCategory[] ContentCategories = {

            new ContentCategory() { Content = Contents[0],  Category = Categories[0]},
            new ContentCategory() { Content = Contents[0],  Category = Categories[1]},
            new ContentCategory() { Content = Contents[0],  Category = Categories[4]},
            new ContentCategory() { Content = Contents[1],  Category = Categories[0]},
            new ContentCategory() { Content = Contents[1],  Category = Categories[1]},
            new ContentCategory() { Content = Contents[1],  Category = Categories[5]},
            new ContentCategory() { Content = Contents[2],  Category = Categories[1]},
            new ContentCategory() { Content = Contents[2],  Category = Categories[4]},
            new ContentCategory() { Content = Contents[2],  Category = Categories[5]},
            new ContentCategory() { Content = Contents[2],  Category = Categories[7]},
        };

    }
}
