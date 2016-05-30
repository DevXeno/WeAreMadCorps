﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreMadCorps.Dashboard;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.Recrutement
{
    public static class PosteData
    {
        public static List<Poste> GetData()
        {
            return new List<Poste> {
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W") },
                    Name = "Bryan Garret",
                    Distance = "0.2",
                    IsOnLine = true,
                    Stars = "3.5"
                },
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1rYGvGU") },
                    Name = "James Simpson",
                    Distance = "0.5",
                    IsOnLine = true,
                    Stars = "5"
                },
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1EhFsao") },
                    Name = "Kathryn Newer",
                    Distance = "1.1",
                    IsOnLine = true,
                    Stars = "4.5"
                },
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1oIYpso") },
                    Name = "Amanda Stevens",
                    Distance = "1.3",
                    IsOnLine = false,
                    Stars = "4"
                },
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/10CbVZE") },
                    Name = "Wayne Andrews",
                    Distance = "3.0",
                    IsOnLine = true,
                    Stars = "4.5"
                },
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1vCRbKh ") },
                    Name = "David Cameron",
                    Distance = "4",
                    IsOnLine = true,
                    Stars = "1.5"
                },
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1rPp1vm") },
                    Name = "Jeff Alexander",
                    Distance = "4.2",
                    IsOnLine = true,
                    Stars = "3.5"
                },
                new Poste () {
                    ImageSource = new UriImageSource { Uri = new Uri ("http://bit.ly/1sXguu1") },
                    Name = "Boby Fisher",
                    Distance = "5.1",
                    IsOnLine = true,
                    Stars = "4.5"
                }
            };
        }

    }
}
