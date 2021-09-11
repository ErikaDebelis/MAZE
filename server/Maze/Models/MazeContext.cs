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
            Text = ". . . room number 13,They weren’t really comfortable here and I knew why, 'No, no,' they said. 'We're not all superstitious.' 'Only some of you, then?' They were worried it might be Friday. Well, it's true that it was closer to the end of the week than they realized. It takes a great deal of experience, certainly more than they possessed, to understand how time works in the Maze. The dock thought it was six in the evening, Quickly moving on we came to . . .",
          },

          new Page
          {
            PageId = 14,
            Picture = ,
            Text = ". . . one of the biggest rooms in the House, All three doorways were dark. 'Afraid to go out?' I asked. Since they tried to think of themselves as adults, they didn't care for my question. 'Not really,' said the thoughtful one, 'but that doesn't mean we have to go running around out there just to prove something to you.' I knew she would bear watching.'Choose then!' I cried, as if my feelings were hurt. 'Pay no attention to anything I say.' I knew they couldn't afford not to listen to me entirely . . . they were so easily led Turning around, the group took a path that completely surprised me after all, and I followed them to . . .",
          },

          new Page
          {
            PageId = 15,
            Picture = ,
            Text = ". . . room number 15. Just as we entered l heard a thump and the sound of footsteps hurrying away. Somewhere a door slammed. 'At least three of us can sit down here' said one. There were only three possible choices. Leaning on the sacrificial tripod I was suddenly moved to say, 'Perhaps these numbers relate to each other in some specific combination . . ' Immediately I regretted this act of charity . . . sometimes I think, after all these years, that I don’t really know myself. One of them thought he had worked it out and, very pleased with himself, led us into . . . ",
          },

          new Page
          {
            PageId = 16,
            Picture = ,
            Text = ". . . a stone chamber which reminded me of my old neighbors. Of course, that was a long time ago now, but would you believe their descendants are still telling stories about me and my family to their children? Even if most of the stories are lies and exaggerations, it is immortality of a sort. As I passed in front of an open doorway a figure, crossing the hall outside, saw me and immediately ran off. 'Who was that?' they asked. 'Another visitor, to be sure.' 'Why did he run away?' 'You probably scared him.' I said, and they apparently believed me. With few regrets on my part we left for . . .",
          },

          new Page
          {
            PageId = 17,
            Picture = ,
            Text = ". . .  a room with a floor of sand. 'Amphorae’ I pronounced; empty, of course, 'This is an easier choice to make' they said. “You may think so' I muttered to myself, 'but your choices are more limited than you know.' One should never accept the obvious here. If you think of the Maze as a machine, confusion is its product, and the machine was hard at work. Ignoring my good advice they hurried into . . . ",
          },

          new Page
          {
            PageId = 18,
            Picture = ,
            Text = ". . . a much warmer room. Shadows danced across the floor to the fire's music, 'Someone's lost his hat.' 'Are you sure it's the hat that is lost?' I asked reasonably enough. No one would answer me. Ducking behind a curtain and hurrying down a passageway we came out in . . . .",
          },

          new Page
          {
            PageId = 19,
            Picture = ,
            Text = ". . . a shaded portico. A late afternoon sun warmed the rough blocks of stone. 'Get out of the way!' someone called. We moved into the yard, squinting at the strong light. One of them sat on a marble bench after I politely pushed some flowers aside. 'Did you pick these for me?' she asked, looking me in the eye. I had to tell her the truth, In another part of the grounds someone was singing but they couldn't make out the words. Like children they soon became restless and impatient to see something new, so we went on to  . . .",
          },

          new Page
          {
            PageId = 20,
            Picture = ,
            Text = ". . . room number 20. The ringing stopped as soon as we entered. 'What is the matter now?' I asked them. 'Too many animals for a proper house!' They walked carefully around the edges of the room. I watched with an amusement shared, I think, by the wise old tortoise. With backward looks and muttered comments about turtles they left room number 20 and entered . . .",
          },

          new Page
          {
            PageId = 21,
            Picture = ,
            Text = ". . . a yard containing shrubs trimmed in ornamental shapes. 'This,' I began, 'is called . . . ' 'We know what the name is,' they interrupted. 'Why don’t you just tell us which way to go?' 'I wasn’t referring to the plants,' I said in a huff. I refused to say anything else, leaving them to find their own way to . . .",
          },

          new Page
          {
            PageId = 22,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 23,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 24,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 25,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 26,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 27,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 28,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 29,
            Picture = ,
            Text = ". . .  . . .",
          },

          new Page
          {
            PageId = 30,
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