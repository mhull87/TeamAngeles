using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeetingPlanner.Data;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingPlannerContext>>());
            // Look for any movies.
            if (context.Bulletin.Any())
            {
                return;   // DB has been seeded
            }

            context.Bulletin.AddRange(
                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/1/3"),
                    Conducting = "John Dory",
                    OpeningSong = "#217 Come, Let Us Anew",
                    Invocation = "By Invitation",
                    SacramentSong = "#190 In Memory of the Crucified",
                    Speaker = "",
                    IntermediateSong = "",
                    ClosingSong = "#216 We Are Sowing",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/1/10"),
                    Conducting = "John Dory",
                    OpeningSong = "#26 Joseph Smith's First Prayer",
                    Invocation = "By Invitation",
                    SacramentSong = "#195 How Great the Wisdom and the Love",
                    Speaker = "James Truett",
                    Topic = "Charity",
                    IntermediateSong = "",
                    ClosingSong = "#18 The Voice of God Again Is Heard",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/1/17"),
                    Conducting = "John Dory",
                    OpeningSong = "#13 An Angel from on High",
                    Invocation = "By Invitation",
                    SacramentSong = "#194 There Is a Green Hill Far Away",
                    Speaker = "Linda Soper",
                    Topic = "Faith",
                    IntermediateSong = "",
                    ClosingSong = "#308 Love One Another",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/1/24"),
                    Conducting = "John Dory",
                    OpeningSong = "#270 I'll Go Where You Want Me to Go",
                    Invocation = "By Invitation",
                    SacramentSong = "#169 As Now We Take the Sacrament",
                    Speaker = "Peter Pixton",
                    Topic = "Service",
                    IntermediateSong = "As Sisters In Zion by Emily Windham",
                    ClosingSong = "#85 How Firm a Foundation",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/2/7"),
                    Conducting = "Pete Graham",
                    OpeningSong = "#143 Let the Holy Spirit Guide",
                    Invocation = "By Invitation",
                    SacramentSong = "#170 God, Our Father, Hear Us Pray",
                    Speaker = "",
                    IntermediateSong = "",
                    ClosingSong = "#109 Search, Ponder and Pray",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/2/14"),
                    Conducting = "Pete Graham",
                    OpeningSong = "#10 Come Sing to the Lord",
                    Invocation = "By Invitation",
                    SacramentSong = "#172 In Humility, Our Savior",
                    Speaker = "Amy Bassett",
                    Topic = "Love",
                    IntermediateSong = "",
                    ClosingSong = "#20 God of Power, God of Right",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/2/21"),
                    Conducting = "Pete Graham",
                    OpeningSong = "#301 I Am a Child of God",
                    Invocation = "By Invitation",
                    SacramentSong = "#176 'Tis Sweet to Sing the Matchless Love",
                    Speaker = "Wilson Blackburn",
                    Topic = "Forgiveness",
                    IntermediateSong = "I Need Thee Every Hour by the ward choir",
                    ClosingSong = "#263 Go Forth With Faith",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/2/28"),
                    Conducting = "Pete Graham",
                    OpeningSong = "#123 Oh, May My Soul Commune With Thee",
                    Invocation = "By Invitation",
                    SacramentSong = "#193 I Stand All Amazed",
                    Speaker = "Barbara Clark",
                    Topic = "Sacrifice",
                    IntermediateSong = "",
                    ClosingSong = "#279 Thy Holy Word",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/3/7"),
                    Conducting = "Trent Marshall",
                    OpeningSong = "#28 Saints, Behold How Great Jehovah",
                    Invocation = "By Invitation",
                    SacramentSong = "#196 Jesus, Once of Humble Birth",
                    Speaker = "",
                    IntermediateSong = "",
                    ClosingSong = "#137 Testimony",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/3/14"),
                    Conducting = "Trent Marshall",
                    OpeningSong = "#66 Rejoice, the Lord is King!",
                    Invocation = "By Invitation",
                    SacramentSong = "#174 While of These Emblems We Partake",
                    Speaker = "William Wesley",
                    Topic = "Humility",
                    IntermediateSong = "",
                    ClosingSong = "#304 Teach Me to Walk in the Light",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/3/21"),
                    Conducting = "Trent Marshall",
                    OpeningSong = "#21 Come, Listen to a Prophet's Voice",
                    Invocation = "By Invitation",
                    SacramentSong = "#175 O God, the Eternal Father",
                    Speaker = "Maria Gonzalez",
                    Topic = "Love",
                    IntermediateSong = "#86 How Great Thou Art",
                    ClosingSong = "#128 When Faith Endures",
                    Benediction = "By Invitation"
                },

                new Bulletin
                {
                    BulletinDate = DateTime.Parse("2021/3/28"),
                    Conducting = "Trent Marshall",
                    OpeningSong = "#7 Israel, Israel God Is Calling",
                    Invocation = "By Invitation",
                    SacramentSong = "#181 Jesus of Nazareth, Savior and King",
                    Speaker = "Jonathon Turnbridge",
                    Topic = "Charity",
                    IntermediateSong = "",
                    ClosingSong = "#6 Redeemer of Israel",
                    Benediction = "By Invitation"
                }
            );
            context.SaveChanges();
        }
    }
}
