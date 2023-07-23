// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using Task1;

Club barca = new Club("Barcelona");
Club liver = new Club("Liverpool");
Club milan = new Club("Milan");

List<Club> clubs = new List<Club>() { barca, liver, milan };

Player bp1 = new Player("Marc-André ter Stegen", Position.GoalKipper, Country.Germany, barca.Id, new int[] { 0, 0, 0});
Player bp2 = new Player("Ronald Araújo", Position.Deffender, Country.Uruguay, barca.Id, new int[] { 3, 2, 4 });
Player bp3 = new Player("Andreas Christensen", Position.Deffender, Country.Denmark, barca.Id, new int[] { 0, 0, 1 });
Player bp4 = new Player("Frenkie de Jong", Position.Middlfilder, Country.Holland, barca.Id, new int[] { 3, 4, 2});
Player bp5 = new Player("Pedri", Position.Middlfilder, Country.Spain, barca.Id, new int[] { 2, 3, 6 });
Player bp6 = new Player("Robert Lewandowski", Position.Forward, Country.Pland, barca.Id, new int[] { 28, 31, 24 });
Player bp7 = new Player("Ansu Fati", Position.Forward, Country.Spain, barca.Id, new int[] { 8, 7, 6 });
Player bp8 = new Player("Ousmane Dembélé", Position.Forward, Country.France, barca.Id, new int[] { 11, 12, 7 });
Player lp1 = new Player("Alisson Becker", Position.GoalKipper, Country.Brazil, liver.Id, new int[] { 0, 0, 0 });
Player lp2 = new Player("Adrián", Position.GoalKipper, Country.Spain, liver.Id, new int[] { 0, 0, 0 });
Player lp3 = new Player("Virgil van Dijk", Position.Deffender, Country.Holland, liver.Id, new int[] { 4, 3, 4 });
Player lp4 = new Player("Fabinho", Position.Middlfilder, Country.Brazil, liver.Id, new int[] { 6, 2, 4 });
Player lp5 = new Player("Darwin Núñez", Position.Forward, Country.Uruguay, liver.Id, new int[] { 11, 10, 12 });
Player lp6 = new Player("Mohamed Salah", Position.Forward, Country.Egypt, liver.Id, new int[] { 31, 29, 30 });
Player lp7 = new Player("Diogo Jota", Position.Forward, Country.Portugal, liver.Id, new int[] { 9, 9, 15 });
Player mp1 = new Player("Mike Maignan", Position.GoalKipper, Country.France, milan.Id, new int[] { 0, 0, 0 });
Player mp2 = new Player("Simon Kjær", Position.Deffender, Country.Denmark, milan.Id, new int[] { 2, 1, 3 });
Player mp3 = new Player("Christian Pulisic", Position.Middlfilder, Country.USA, milan.Id, new int[] { 4, 5, 3 });
Player mp4 = new Player("Rafael Leão", Position.Forward, Country.Portugal, milan.Id, new int[] { 11, 12, 14 });
Player mp5 = new Player("Olivier Giroud", Position.Forward, Country.France, milan.Id, new int[] { 13, 14, 9 });

barca.Players = new List<Player>() { bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8 };
liver.Players = new List<Player>() { lp1, lp2, lp3, lp4, lp5, lp6, lp7 };
milan.Players = new List<Player>() { mp1, mp2, mp3, mp4, mp5 };

// Unions
//IEnumerable<Player> players = barca.Players.Union(liver.Players).Union(milan.Players);
IEnumerable<Player> players = (from bp in barca.Players select bp)
    .Concat(from lp in liver.Players select lp).Concat(from mp in milan.Players select mp);

// Joins
//var playersJoin = players.Join(clubs, p => p.ClubId, c => c.Id, (p, c) => new {PName = p.Name, CName = c.Name});
//var playersJoin = from p in players join c in clubs on p.ClubId equals c.Id select new { PName = p.Name, CName = c.Name };
//var playersJoin = clubs.Join(players, c => c.Id, p => p.ClubId, (c, p) => new {PName = p.Name, CName = c.Name});
var playersJoin = from c in clubs join p in players on c.Id equals p.ClubId select new { PName = p.Name, CName = c.Name };

// Group by one property
//IEnumerable<IGrouping<Position, Player>> playersGroup = players.GroupBy(p => p.Position);
//IEnumerable<IGrouping<Position, Player>> playersGroup = from p in players group p by p.Position into p select p;
//IEnumerable<IGrouping<int, Player>> playersGroup = players.GroupBy(p => p.ClubId);
//IEnumerable<IGrouping<int, Player>> playersGroup = from p in players group p by p.ClubId into p select p;

// Group by many property
//var playersGroup = players.GroupBy(p => new { p.Position, p.Nationality });
//var playersGroup = from p in players group p by new { p.Position, p.Nationality } into p select p;
//var playersGroup = players.GroupBy(p => new { p.ClubId, p.Nationality });
//var playersGroup = from p in players group p by new { p.ClubId, p.Nationality } into p select p;

// Group by aggregate
//IEnumerable<IGrouping<double, Player>> playersGroup = players.GroupBy(p => p.Goals.Average());
//IEnumerable<IGrouping<double, Player>> playersGroup = from p in players group p by p.Goals.Average() into p select p;
//IEnumerable<IGrouping<string, Player>> playersGroup = players.GroupBy(p => p.Goals.Average() < 10 ? "Less then 10" : "More then 10");
//IEnumerable<IGrouping<string, Player>> playersGroup = from p in players group p by p.Goals.Average() < 4 ? "Less then 4" : "More then 4" into p select p;
//IEnumerable<IGrouping<int, Player>> playersGroup = players.GroupBy(p => p.Goals.Max());
IEnumerable<IGrouping<string, Player>> playersGroup = from p in players group p by p.Goals.Max() > 20 ? "Super geloeador" : p.Goals.Max() > 10 ? "Normal geloeador" : "Bad geloeador" into p select p;

foreach (var p in players);
{
    // Console.WriteLine(p);
}

foreach (var p in playersJoin)
{
    //Console.WriteLine($"{p.PName} - {p.CName}");
}

foreach (var player in playersGroup)
{
    Console.WriteLine(player.Key);

    foreach (Player p in player)
    {
        Console.WriteLine("\t" + p);
    }
}

