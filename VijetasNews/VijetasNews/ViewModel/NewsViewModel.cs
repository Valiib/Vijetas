using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VijetasNews.Model;

namespace VijetasNews.ViewModel
{
    class NewsViewModel
    {
        
        public ObservableCollection<NewsModel> NewsModels { get; set; }

        public NewsViewModel() => NewsModels = new ObservableCollection<NewsModel>
            {
                new NewsModel { Title = "Hello World", Category = "Sport",
                   
                    
                    
                    ImageLink = "http://static.superiorwallpapers.com/images/lthumbs/2015-11/11316_Magic-time-in-the-mountains-nature-landscape.jpg",
                    
                    
                    PostId = "1", Paragraphs = "Hello this is my first post on this is app i would tell you this is best app I have ever used in this last day", AdditionalData = "Best app I have ever used in this last day" },
          new NewsModel { Title = "Hello World", Category = "Sport",
                   
                    
                    
                    ImageLink = "http://static.superiorwallpapers.com/images/lthumbs/2015-11/11316_Magic-time-in-the-mountains-nature-landscape.jpg",
                    
                    
                    PostId = "1", Paragraphs = "Hello this is my first post on this is app i would tell you this is best app I have ever used in this last day", AdditionalData = "Best app I have ever used in this last day" },
          new NewsModel { Title = "Hello World", Category = "Sport",
                   
                    
                    
                    ImageLink = "http://static.superiorwallpapers.com/images/lthumbs/2015-11/11316_Magic-time-in-the-mountains-nature-landscape.jpg",
                    
                    
                    PostId = "1", Paragraphs = "Hello this is my first post on this is app i would tell you this is best app I have ever used in this last day", AdditionalData = "Best app I have ever used in this last day" },
          new NewsModel { Title = "Hello World", Category = "Sport",
                   
                    
                    
                    ImageLink = "http://static.superiorwallpapers.com/images/lthumbs/2015-11/11316_Magic-time-in-the-mountains-nature-landscape.jpg",
                    
                    
                    PostId = "1", Paragraphs = "Hello this is my first post on this is app i would tell you this is best app I have ever used in this last day", AdditionalData = "Best app I have ever used in this last day" },
          new NewsModel { Title = "Hello World", Category = "Sport",
                   
                    
                    
                    ImageLink = "http://static.superiorwallpapers.com/images/lthumbs/2015-11/11316_Magic-time-in-the-mountains-nature-landscape.jpg",
                    
                    
                    PostId = "1", Paragraphs = "Hello this is my first post on this is app i would tell you this is best app I have ever used in this last day", AdditionalData = "Best app I have ever used in this last day" }
          
                };
    }   
}
