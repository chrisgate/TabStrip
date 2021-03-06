﻿using System;
using System.Collections.ObjectModel;
using TabStrip.FormsPlugin.Abstractions;
using Xamarin.Forms;

namespace TabStrip.Sample
{
    public partial class MainPage : ContentPage
	{
        public class Context
        {
            public Context()
            {
                Data = new ObservableCollection<TabModel>(new[]
                {
                    new TabModel
                    {
                        Header = new Tuple<View, object>(new HeaderView(), new { Title = "Tab 1" }),
                        View = new Tuple<View, object>(new HelloView(), new { Message = "Tab Strip 1" })
                    },
                    new TabModel
                    {
                        Header = new Tuple<View, object>(new HeaderView(), new { Title = "Tab 2" }),
                        View = new Tuple<View, object>(new HelloView(), new { Message = "Tab Strip 2" })
                    },
                    new TabModel
                    {
                        Header = new Tuple<View, object>(new HeaderView(), new { Title = "Tab 3" }),
                        View = new Tuple<View, object>(new HelloView(), new { Message = "Tab Strip 3" })
                    },
                    new TabModel
                    {
                        Header = new Tuple<View, object>(new HeaderView(), new { Title = "Tab 4" }),
                        View = new Tuple<View, object>(new HelloView(), new { Message = "Tab Strip 4" })
                    },
                    new TabModel
                    {
                        Header = new Tuple<View, object>(new HeaderView(), new { Title = "Tab 5" }),
                        View = new Tuple<View, object>(new HelloView(), new { Message = "Tab Strip 5" })
                    }
                });
                Position = 2;
                Title = "This is a test title";
            }

            public string Title { get; set; }
            public int Position { get; set; }
            public ObservableCollection<TabModel> Data { get; set; }            
        }

		public MainPage()
		{
			InitializeComponent();
            BindingContext = new Context();
        }
	}
}
