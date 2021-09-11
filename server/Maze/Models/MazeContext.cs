using Microsoft.EntityFrameworkCore;

namespace Maze.Models
{
  public class MazeContext : DbContext
  {
    public MazeContext(DbContextOptions<MazeContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Page>()
        .HasData(

          new Page
          {
            PageId = 1,
            Picture = ,
            Text = ". . . the entrance hall of the Maze, They looked carefully at the bronze doors, trying to choose.The uncertainty of visitors is one of my little pleasures, 'It’s easy to get lost,' I said helpfully. 'This can be a sinister place,' The sun glared at me through the gateway, Something was ringing behind one of the doors. They spent some time trying to decide which door it was, not understanding that the silences of the Maze are as eloquent as the sounds. 'Decisions, decisions,' one said. 'Too many decisions.' 'The story of my life,' said another. 'We don’t want to be late,' said a third, opening one of the doors. 'Nary a soul to be seen,' said the first, peering into the gloom. I waited patiently for them to choose which way to go . . . into . . .",
          },

          new Page
          {
            PageId = 2,
            Picture = ,
            Text = ". . . a bright room whose walls were in some disrepair. The floorboards creaked and groaned; the plaster made a gritty sound. They studied the old frescoes for clues but missed the obvious signs. 'Are we on the right path?' they asked. Keeping in mind what a relative term 'right' is, I assured them they were, indeed, on the right path. As for the 'correct' path or the 'most appropriate' path. . . Well, that might be something else. Full of confidence now they marched out to . . .",
          },

          new Page
          {
            PageId = 3,
            Picture = ,
            Text = ". . . an entirely different kind of place.The group complained of feeling 'all turned around,' as well they might. Because no one wanted to stay here very long they missed the real sign while looking through the obvious. People in their situation, confronted with a challenge, tend to accept the terms of the challenge as a given, without examining it from all sides. How many sides does that problem have? They don’t know. We passed down a long flight of stairs, through some sort of pantry, and on into . . .",
          },

          new Page
          {
            PageId = 4,
            Picture = ,
            Text = ". . . the great hall of many doors.'What a foolish face,' I snorted. 'Pay no attention' A sound made them all turn suddenly. A small black cat ran out of a door to my right, sniffed at us, and, before I could move, ran out of the hall, It was fortunate that I was still standing with the rest of them or they might have noticed. Faint voices came down one of the corridors.'Shall we toss a coin?' I asked. 'Or have you made up your minds?' They hadn't made up their minds, and they had no coins. By a process of elimination they decided to go to . . .",
          },

          new Page
          {
            PageId = 5,
            Picture = "",
            Text = ". . . the tree room.'Are these real?' they asked, I told them the trees were as real as anything else in the House. As this was an important decision I encouraged them to take their time. After all, the more they think about the possibilities the more choices they have to make, What were their chances of choosing wisely . . . one in four? Two in four perhaps, if I was generous about it. . . and why not be generous? There are one hundred ninety doors in this part of the House, counting the gate . . . enough for everyone. Making a choice, they entered a very long, dark corridor and at last came out into . . .",
          },

          new Page
          {
            PageId = 6,
            Picture = "",
            Text = ". . . a gloomy, cavelike place far underground, Even I was oppressed by the weight that hung over our heads. A very small hole, high above, admitted a feeble light. Standing in the light one ofthem put his hand out. 'I think it may be raining out there . . .' They didn't like the look of the place. 'You continue to judge everything by the way it looks!' I cried, exasperated by their timidity. I knew I shouldn't have said anything. If you think of all the deceptions practiced in my family, particularly on my father . . . We went down the only way open to us and came to . . .",
          },

          new Page
          {
            PageId = 7,
            Picture = ,
            Text = ". . . a pleasant room with three doors and a lamp. Looking at the picture on the wall they decided it wasn't a very good likeness. One of them almost fell over something on the floor. 'Why don’t they pick up after themselves?' he said, sounding like an old man. 'Weren’t you ever irresponsible?' I asked, thinking of my childhood and how wild I had been.Music was being played somewhere nearby. We stopped to listen for a moment. Leaving the picture looking out at an empty room we went on to . . .",
          },

          new Page
          {
            PageId = 8,
            Picture = ,
            Text = ". . . a vaulted chamber lit by a single bulb. Someone knocked a bowl off the table. The crash echoed from the ceiling and whispered away down the corridors, I broke another on purpose, 'Make sure to take that with you’ I said, 'You can never tell when you might need it,' 'Take what?' they wanted to know. 'Isn't it obvious?' Taking a vote among themselves they went on to . . .",
          },

          new Page
          {
            PageId = 9,
            Picture = ,
            Text = ". . . what appeared to be an old storeroom. Dust obscured a damaged painting making it hard to understand just what the artist had intended. 'This could be a trick of some sort,' one said. 'We might be going around in circles.' 'I don’t think so,' said the thoughtful one. 'I think we’re supposed to think it’s a trick . . . that’s the trick. They all looked at me. 'Yes,' I said, 'I’m sure you're right about that.' With doubtful looks they left for . . .",
          },

          new Page
          {
            PageId = 10,
            Picture = "",
            Text = ". . . a room that smelled of paint, Faint voices, apparently in an argument, came from behind the locked door. 'You know,' said one, 'that sounds like us in there . . . ' They tried the door but, naturally, it wouldn't open. The voices stopped when the doorknob rattled. One picked up the umbrella. 'It may rain where we’re going.' I signaled my approval and, after a short rest, we came to . . .",
          },

          new Page
          {
            PageId = 11,
            Picture = "",
            Text = ". . . an airy room with many doors. It was a big space, but I still felt crowded. I’ve always hated confinement, 'Whatever you do,' I warned them, 'don't touch that!' 'This must be an important room,' said one of them. 'It has more doors than any of the others . . .' This was not true but I didn't want to interrupt. 'With so many paths crossing here we must be close to the center,' she continued. I had noticed this guest before; I would have to be careful, 'This is an important choice,' I said, trying to encourage them. Gratefully leaving the room behind we walked all the way to . . .",
          }

                    new Page
          {
            PageId = 12,
            Picture = ,
            Text = ". . . a spacious room with a hole in the floor, A ladder led downinto the shadows. Outside, leaves shook in the wind, Theydidn't like the look of that hole in the floor.'Too dark down there!' they cried, “Who knows what's at the bottom. 'They looked at me again. Probably a room of some kind,' I volunteered quickly. 'But you know what l say about appearances.' It would have been a relief to get outside for a while. They wanted to know if they had been here before. . . . How could I answer that? 'I have the strangest feeling of deja vu,' said one who, bolder than the rest, led us into . . .",
          },

          new Page
          {
            PageId = 13,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 14,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 15,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 16,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 17,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 18,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 19,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 20,
            Picture = ,
            Text = ". . .  . . .",
          },
        );
    }

    public DbSet<Page> Pages { get; set; }

  }
}


          // new Page
          // {
          //   PageId = 1,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 2,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 3,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 4,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 5,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 6,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 7,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 8,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 9,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },

          // new Page
          // {
          //   PageId = 0,
          //   Picture = ,
          //   Text = ". . .  . . .",
          // },