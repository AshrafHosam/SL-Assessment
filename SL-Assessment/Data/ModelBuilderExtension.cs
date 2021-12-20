using Microsoft.EntityFrameworkCore;
using SL_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SL_Assessment.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoBrief>().HasData(
                new VideoBrief
                {
                    Id = 1,
                    Title = "How to control your facial expressions",
                    Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                    ImageUrl = "~/images/0001.png",
                    VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                },
                 new VideoBrief
                 {
                     Id = 2,
                     Title = "How to control your facial expressions",
                     Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                     ImageUrl = "~/images/0008.png",
                     VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                 },
                  new VideoBrief
                  {
                      Id = 3,
                      Title = "How to control your facial expressions",
                      Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                      ImageUrl = "~/images/0002.png",
                      VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                  },
                   new VideoBrief
                   {
                       Id = 4,
                       Title = "How to control your facial expressions",
                       Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                       ImageUrl = "~/images/0007.png",
                       VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                   },
                    new VideoBrief
                    {
                        Id = 5,
                        Title = "How to control your facial expressions",
                        Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                        ImageUrl = "~/images/0008.png",
                        VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                    },
                     new VideoBrief
                     {
                         Id = 6,
                         Title = "How to control your facial expressions",
                         Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                         ImageUrl = "~/images/0001.png",
                         VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                     },
                      new VideoBrief
                      {
                          Id = 7,
                          Title = "How to control your facial expressions",
                          Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                          ImageUrl = "~/images/0002.png",
                          VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                      }
                );
        }
    }
}