using Microsoft.AspNetCore.Components;
using TomArcherMusic.Services.Interfaces;
using TomArcherMusicContracts;
using System;
using System.Collections.Generic;

namespace TomArcherMusic.Pages
{
    public partial class Index
    {
        List<MusicCardDto> musicCards;
        protected override async Task OnInitializedAsync()
        {
            musicCards = await musicCardService.GetAll();
        }

        public string GetPosition(MusicCardDto musicCard)
        {
            switch(musicCards.IndexOf(musicCard))
            {
                case 0:
                    return "slider--item-left";
                case 1:
                    return "slider--item-center";
                case 2:
                    return "slider--item-right";
                default:
                    return "";
            }
        }


    }
}
