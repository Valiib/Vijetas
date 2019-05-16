using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VijetasNews.ViewModel
{
    class CategoryViewModel
    {
             public ObservableCollection<Model.CategoryModel> CategoryViewModels { get; set; }


       public ObservableCollection<Model.CategoryModel> DataFormModel { get; set; }

        public CategoryViewModel()
        {
            

            var DataFormModel = new ObservableCollection<Model.NewsModel>
            {
                new Model.NewsModel()
                {
                    AdditionalData = "Sports are interesting",
                    Category = "Sport",
                    ImageLink  =  "https://www.clipartmax.com/png/full/99-990123_how-its-made-science-apparatus-clipart.png",
                    Title = "Maradona is back",
                    Paragraphs = "Diego Armando Maradona (Spanish pronunciation: [ˈdjeɣo maɾaˈðona], born 30 October 1960) is an Argentine retired professional footballer and current manager of Mexican second division club Dorados. Many in the sport, including football writers, players, and fans, regard him as the greatest football player of all time. He was joint FIFA Player of the 20th Century with Pelé.[6][7] Maradona's vision, passing, ball control and dribbling skills was combined with his small stature (1.65 m or 5 ft 5 in), giving him a low center of gravity which allowed him to maneuver better than most other football players; he would often dribble past multiple opposing players on a run. His presence and leadership on the field had a great effect on his team's general performance, while he would often be singled out by the opposition. A precocious talent, Maradona was given the nickname 'El Pibe de Oro' ('The Golden Boy'), a name that stuck with him throughout his career.[8] An advanced playmaker who operated in the classic number 10 position, Maradona was the first player in football history to set the world record transfer fee twice, first when he transferred to Barcelona for a then world record £5 million, and second, when he transferred to Napoli for another record fee £6.9 million.[9] He played for Argentinos Juniors, Boca Juniors, Barcelona, Napoli, Sevilla and Newell's Old Boys during his club career, and is most famous for his time at Napoli and Barcelona where he won numerous accolades. In his international career with Argentina, he earned 91 caps and scored 34 goals. Maradona played in four FIFA World Cups, including the 1986 World Cup in Mexico where he captained Argentina and led them to victory over West Germany in the final, and won the Golden Ball as the tournament's best player. In the 1986 World Cup quarter final, he scored both goals in a 2–1 victory over England that entered football history for two different reasons. The first goal was an unpenalized handling foul known as the 'Hand of God', while the second goal followed a 60 m (66 yd) dribble past five England players, voted 'Goal of the Century' by FIFA.com voters in 2002.[10] Maradona became coach of Argentina in November 2008. He was in charge of the team at the 2010 World Cup in South Africa before leaving at the end of the tournament. He coached Dubai-based club Al Wasl in the UAE Pro-League for the 2011–12 season. In 2017, Maradona became the coach of Fujairah before leaving at the end of the season.[11] In May 2018, Maradona was announced as the new chairman of Belarusian club Dynamo Brest.[12] He arrived in Brest and was presented by the club to start his duties in July.[13] In September 2018 Maradona was appointed coach of Mexican club Dorados.",
                    PostId="1"
                }
            };


            CategoryViewModels = new ObservableCollection<Model.CategoryModel>
            {
                new Model.CategoryModel() { CategoryType = "Sport", UrlImage = "https://www.bls.gov/spotlight/2017/sports-and-exercise/images/cover_image.jpg", NewsOnThis = DataFormModel} ,
                new Model.CategoryModel() { CategoryType = "Art", UrlImage = "https://static.boredpanda.com/blog/wp-content/uploads/2017/02/IMG_20170114_222025_931-58a01296a1b60__880.jpg" },
                new Model.CategoryModel() { CategoryType = "Science", UrlImage="https://www.clipartmax.com/png/full/99-990123_how-its-made-science-apparatus-clipart.png" },
                new Model.CategoryModel() { CategoryType = "Lifestyle", UrlImage="https://pbs.twimg.com/media/B6uN1LkCUAEu01G.jpg" }
            };
        }
    }
}
