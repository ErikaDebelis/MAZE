using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;

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
            Img = "../wwwroot/images/1.PNG",
            Text = ". . . the entrance hall of the Maze. They looked carefully at the bronze doors, trying to choose. The uncertainty of visitors is one of my little pleasures. 'It’s easy to get lost,' I said helpfully. 'This can be a sinister place,' The sun glared at me through the gateway. Something was ringing behind one of the doors. They spent some time trying to decide which door it was, not understanding that the silences of the Maze are as eloquent as the sounds. 'Decisions, decisions,' one said. 'Too many decisions.' 'The story of my life,' said another. 'We don’t want to be late,' said a third, opening one of the doors. 'Nary a soul to be seen,' said the first, peering into the gloom. I waited patiently for them to choose which way to go . . . into . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/1.PNG' usemap='#pg1-image-map' >
                <map name='pg1-image-map'>
                  <area
                    target=''
                    alt='door 20'
                    data-index=''
                    data-title='20'
                    href='/Maze/index/20'
                    onclick = 'show('20.PNG')'
                    coords='223,84,299,117'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 26'
                    data-index=''
                    data-title='26'
                    href='/Maze/index/26'
                    onclick = 'show('26.PNG')'
                    coords='431,81,510,117'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 41'
                    data-index=''
                    data-title='41'
                    href='/Maze/index/41'
                    onclick = 'show('41.PNG')'
                    coords='586,115,649,113,641,71,585,78'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 21'
                    data-index=''
                    data-title='21'
                    href='/Maze/index/21'
                    onclick = 'show('21.PNG')'
                    coords='698,61,701,110,772,105,767,55'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 2,
            Img = "../wwwroot/images/2.PNG",
            Text = ". . . a bright room whose walls were in some disrepair. The floorboards creaked and groaned; the plaster made a gritty sound. They studied the old frescoes for clues but missed the obvious signs. 'Are we on the right path?' they asked. Keeping in mind what a relative term 'right' is, I assured them they were, indeed, on the right path. As for the 'correct' path or the 'most appropriate' path. . . Well, that might be something else. Full of confidence now they marched out to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/2.PNG' usemap='#pg2-image-map' >
                <map name='pg2-image-map'>
                  <area
                    target=''
                    alt='door 29'
                    data-index='29'
                    data-title='29'
                    href='/Maze/index/29'
                    onclick = 'show('29.PNG')'
                    coords='89,80,91,184,156,184,156,93'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 22'
                    data-index='22'
                    data-title='22'
                    href='/Maze/index/22'
                    onclick = 'show('22.PNG')'
                    coords='359,111,358,177,461,178,460,112'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 12'
                    data-index='12'
                    data-title='12'
                    href='/Maze/index/12'
                    onclick = 'show('12.PNG')'
                    coords='654,82,668,172,726,173,711,73'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 3,
            Img = "../wwwroot/images/3.PNG",
            Text = ". . . an entirely different kind of place. The group complained of feeling 'all turned around,' as well they might. Because no one wanted to stay here very long they missed the real sign while looking through the obvious. People in their situation, confronted with a challenge, tend to accept the terms of the challenge as a given, without examining it from all sides. How many sides does that problem have? They don't know. We passed down a long flight of stairs, through some sort of pantry, and on into . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/3.PNG' usemap='#pg3-image-map' >
                <map name='pg3-image-map'>
                  <area
                    target=''
                    alt='door 9'
                    data-index='9'
                    data-title='9'
                    href='/Maze/index/9'
                    onclick = 'show('9.PNG')'
                    coords='446,64,549,117'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 18'
                    data-index='18'
                    data-title='18'
                    href='/Maze/index/18'
                    onclick = 'show('18.PNG')'
                    coords='671,45,666,112,750,107,755,25'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 4,
            Img = "../wwwroot/images/4.PNG",
            Text = ". . . the great hall of many doors.'What a foolish face,' I snorted. 'Pay no attention' A sound made them all turn suddenly. A small black cat ran out of a door to my right, sniffed at us, and, before I could move, ran out of the hall, It was fortunate that I was still standing with the rest of them or they might have noticed. Faint voices came down one of the corridors.'Shall we toss a coin?' I asked. 'Or have you made up your minds?' They hadn't made up their minds, and they had no coins. By a process of elimination they decided to go to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/4.PNG' usemap='#pg4-image-map' >
                <map name='pg4-image-map'>
                  <area
                    target=''
                    alt='door 44'
                    data-index='44'
                    data-title='44'
                    href='/Maze/index/44'
                    onclick = 'show('44.PNG')'
                    coords='74,41,53,115,163,137,179,82'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 29'
                    data-index='29'
                    data-title='29'
                    href='/Maze/index/29'
                    onclick = 'show('29.PNG')'
                    coords='231,100,218,148,264,159,277,118'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 15'
                    data-index='15'
                    data-title='15'
                    href='/Maze/index/15'
                    onclick = 'show('15.PNG')'
                    coords='300,125,288,164,312,168,322,136'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 11'
                    data-index='11'
                    data-title='11'
                    href='/Maze/index/11'
                    onclick = 'show('11.PNG')'
                    coords='371,148,442,183'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 16'
                    data-index='16'
                    data-title='16'
                    href='/Maze/index/16'
                    onclick = 'show('16.PNG')'
                    coords='492,135,502,170,527,164,515,125'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 24'
                    data-index='24'
                    data-title='24'
                    href='/Maze/index/24'
                    onclick = 'show('24.PNG')'
                    coords='540,118,553,161,598,153,583,102'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 43'
                    data-index='43'
                    data-title='43'
                    href='/Maze/index/dbcontext43'
                    onclick = 'show('43.PNG')'
                    coords='634,81,655,142,766,122,746,42'
                    shape='poly' />
                </map>
              </img>
              ")
          },

          new Page
          {
            PageId = 5,
            Img = "../wwwroot/images/5.PNG",
            Text = ". . . the tree room.'Are these real?' they asked, I told them the trees were as real as anything else in the House. As this was an important decision I encouraged them to take their time. After all, the more they think about the possibilities the more choices they have to make, What were their chances of choosing wisely . . . one in four? Two in four perhaps, if I was generous about it. . . and why not be generous? There are one hundred ninety doors in this part of the House, counting the gate . . . enough for everyone. Making a choice, they entered a very long, dark corridor and at last came out into . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/5.PNG' usemap='#pg5-image-map' />
                <map name='pg5-image-map'>
                  <area
                    target=''
                    alt='door 43'
                    data-index='43'
                    data-title='43'
                    href='/Maze/index/43'
                    onclick = 'show('43.PNG')'
                    coords='85,124,63,192,116,186,154,188,157,131,105,126'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 22'
                    data-index='22'
                    data-title='22'
                    href='/Maze/index/22'
                    onclick = 'show('22.PNG')'
                    coords='264,122,264,140,258,178,291,172,322,171,344,176,354,146,337,124,302,125'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 30'
                    data-index='30'
                    data-title='30'
                    href='/Maze/index/30'
                    onclick = 'show('30.PNG')'
                    coords='551,134,517,134,486,124,475,149,468,178,543,177'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 20'
                    data-index='20'
                    data-title='20'
                    href='/Maze/index/20'
                    onclick = 'show('20.PNG')'
                    coords='655,144,643,198,716,196,722,140'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 6,
            Img = "../wwwroot/images/6.PNG",
            Text = ". . . a gloomy, cavelike place far underground, Even I was oppressed by the weight that hung over our heads. A very small hole, high above, admitted a feeble light. Standing in the light one ofthem put his hand out. 'I think it may be raining out there . . .' They didn't like the look of the place. 'You continue to judge everything by the way it looks!' I cried, exasperated by their timidity. I knew I shouldn't have said anything. If you think of all the deceptions practiced in my family, particularly on my father . . . We went down the only way open to us and came to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/6.PNG' usemap='#pg6-image-map' />
                <map name='pg6-image-map'>
                  <area
                    target=''
                    alt='door 40'
                    data-index='40'
                    data-title='40'
                    href='/Maze/index/40'
                    onclick = 'show('40.PNG')'
                    coords='147,147,122,206,208,255,237,195'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 7,
            Img = "../wwwroot/images/7.PNG",
            Text = ". . . a pleasant room with three doors and a lamp. Looking at the picture on the wall they decided it wasn't a very good likeness. One of them almost fell over something on the floor. 'Why don’t they pick up after themselves?' he said, sounding like an old man. 'Weren’t you ever irresponsible?' I asked, thinking of my childhood and how wild I had been. Music was being played somewhere nearby. We stopped to listen for a moment. Leaving the picture looking out at an empty room we went on to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/7.PNG' usemap='#pg7-image-map' />
                <map name='pg7-image-map'>
                  <area
                    target=''
                    alt='door 33'
                    data-index='33'
                    data-title='33'
                    href='/Maze/index/33'
                    onclick = 'show('33.PNG')'
                    coords='96,18,97,80,173,86,175,37'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 36'
                    data-index='36'
                    data-title='36'
                    href='/Maze/index/36'
                    onclick = 'show('36.PNG')'
                    coords='350,47,451,89'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 16'
                    data-index='16'
                    data-title='16'
                    href='/Maze/index/16'
                    onclick = 'show('16.PNG')'
                    coords='635,34,635,85,707,79,705,20'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 8,
            Img = "../wwwroot/images/8.PNG",
            Text = ". . . a vaulted chamber lit by a single bulb. Someone knocked a bowl off the table. The crash echoed from the ceiling and whispered away down the corridors, I broke another on purpose, 'Make sure to take that with you’ I said, 'You can never tell when you might need it,' 'Take what?' they wanted to know. 'Isn't it obvious?' Taking a vote among themselves they went on to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/8.PNG' usemap='#pg8-image-map' />
                <map name='pg8-image-map'>
                  <area
                    target=''
                    alt='door 31'
                    data-index='31'
                    data-title='31'
                    href='/Maze/index/31'
                    onclick = 'show('31.PNG')'
                    coords='12,233,12,295,18,337,136,296,99,220'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 6'
                    data-index='6'
                    data-title='6'
                    href='/Maze/index/6'
                    onclick = 'show('6.PNG')'
                    coords='200,209,198,236,198,257,211,259,215,268,254,256,231,206'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 29'
                    data-index='29'
                    data-title='29'
                    href='/Maze/index/29'
                    onclick = 'show('29.PNG')'
                    coords='314,177,339,225,423,189,398,136'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 12'
                    data-index='12'
                    data-title='12'
                    href='/Maze/index/12'
                    onclick = 'show('12.PNG')'
                    coords='472,94,495,145,532,121,529,115,534,108,519,95,494,76'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 9,
            Img = "../wwwroot/images/9.PNG",
            Text = ". . . what appeared to be an old storeroom. Dust obscured a damaged painting making it hard to understand just what the artist had intended. 'This could be a trick of some sort,' one said. 'We might be going around in circles.' 'I don’t think so,' said the thoughtful one. 'I think we’re supposed to think it’s a trick . . . that’s the trick. They all looked at me. 'Yes,' I said, 'I’m sure you're right about that.' With doubtful looks they left for . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/9.PNG' usemap='#pg9-image-map' />
                <map name='pg9-image-map'>
                  <area
                    target=''
                    alt='door 3'
                    data-index='3'
                    data-title='3'
                    href='/Maze/index/3'
                    onclick = 'show('3.PNG')'
                    coords='85,140,84,174,66,169,64,209,164,229,164,200,148,196,150,166,121,155'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 18'
                    data-index='18'
                    data-title='18'
                    href='/Maze/index/18'
                    onclick = 'show('18.PNG')'
                    coords='530,162,530,185,502,186,503,208,656,210,656,187,630,186,628,163'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 10,
            Img = "../wwwroot/images/10.PNG",
            Text = ". . . a room that smelled of paint, Faint voices, apparently in an argument, came from behind the locked door. 'You know,' said one, 'that sounds like us in there . . . ' They tried the door but, naturally, it wouldn't open. The voices stopped when the doorknob rattled. One picked up the umbrella. 'It may rain where we’re going.' I signaled my approval and, after a short rest, we came to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/10.PNG' usemap='#pg10-image-map' />
                <map name='pg10-image-map'>
                  <area
                    target=''
                    alt='door 34'
                    data-index='34'
                    data-title='34'
                    href='/Maze/index/34'
                    onclick = 'show('34.PNG')'
                    coords='46,60,56,125,139,125,133,59'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 41'
                    data-index='41'
                    data-title='41'
                    href='/Maze/index/41'
                    onclick = 'show('41.PNG')'
                    coords='427,63,482,58,500,130,443,127'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 14'
                    data-index='14'
                    data-title='14'
                    href='/Maze/index/14'
                    onclick = 'show('14.PNG')'
                    coords='594,51,674,44,692,143,612,138'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 11,
            Img = "../wwwroot/images/11.PNG",
            Text = ". . . an airy room with many doors. It was a big space, but I still felt crowded. I’ve always hated confinement, 'Whatever you do,' I warned them, 'don't touch that!' 'This must be an important room,' said one of them. 'It has more doors than any of the others . . .' This was not true but I didn't want to interrupt. 'With so many paths crossing here we must be close to the center,' she continued. I had noticed this guest before; I would have to be careful, 'This is an important choice,' I said, trying to encourage them. Gratefully leaving the room behind we walked all the way to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/11.PNG' usemap='#pg11-image-map' />
                <map name='pg11-image-map'>
                  <area
                    target=''
                    alt='door 40'
                    data-index='40'
                    data-title='40'
                    href='/Maze/index/40'
                    onclick = 'show('40.PNG')'
                    coords='115,214,208,417'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 24'
                    data-index='24'
                    data-title='24'
                    href='/Maze/index/24'
                    onclick = 'show('24.PNG')'
                    coords='594,214,685,417'
                    shape='rect' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 12,
            Img = "../wwwroot/images/12.PNG",
            Text = ". . . a spacious room with a hole in the floor, A ladder led downinto the shadows. Outside, leaves shook in the wind, Theydidn't like the look of that hole in the floor.'Too dark down there!' they cried, “Who knows what's at the bottom. 'They looked at me again. Probably a room of some kind,' I volunteered quickly. 'But you know what l say about appearances.' It would have been a relief to get outside for a while. They wanted to know if they had been here before. . . . How could I answer that? 'I have the strangest feeling of deja vu,' said one who, bolder than the rest, led us into . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/12.PNG' usemap='#pg12-image-map' />
                <map name='pg12-image-map'>
                  <area
                    target=''
                    alt='door 2'
                    data-index='2'
                    data-title='2'
                    href='/Maze/index/2'
                    onclick = 'show('2.PNG')'
                    coords='150,31,146,47,135,56,130,123,185,124,192,61,185,50,185,40'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 21'
                    data-index='21'
                    data-title='21'
                    href='/Maze/index/21'
                    onclick = 'show('21.PNG')'
                    coords='366,66,373,61,376,53,421,54,427,62,438,69,438,124,365,125'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 8'
                    data-index='8'
                    data-title='8'
                    href='/Maze/index/8'
                    onclick = 'show('8.PNG')'
                    coords='630,42,663,36,667,46,675,53,681,124,629,125,624,62,630,56'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 39'
                    data-index='39'
                    data-title='39'
                    href='/Maze/index/39'
                    onclick = 'show('39.PNG')'
                    coords='286,431,352,408,376,430,362,461,316,471,303,481'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 13,
            Img = "../wwwroot/images/13.PNG",
            Text = ". . . room number 13,They weren’t really comfortable here and I knew why, 'No, no,' they said. 'We're not all superstitious.' 'Only some of you, then?' They were worried it might be Friday. Well, it's true that it was closer to the end of the week than they realized. It takes a great deal of experience, certainly more than they possessed, to understand how time works in the Maze. The dock thought it was six in the evening, Quickly moving on we came to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/13.PNG' usemap='#pg13-image-map' />
                <map name='pg13-image-map'>
                  <area
                    target=''
                    alt='door 27'
                    data-index='27'
                    data-title='27'
                    href='/Maze/index/27'
                    onclick = 'show('27.PNG')'
                    coords='39,9,72,9,131,31,130,93,39,67'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 18'
                    data-index='18'
                    data-title='18'
                    href='/Maze/index/18'
                    onclick = 'show('18.PNG')'
                    coords='338,70,465,124'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 25'
                    data-index='25'
                    data-title='25'
                    href='/Maze/index/25'
                    onclick = 'show('25.PNG')'
                    coords='672,34,732,8,762,9,759,67,672,98'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 14,
            Img = "../wwwroot/images/14.PNG",
            Text = ". . . one of the biggest rooms in the House, All three doorways were dark. 'Afraid to go out?' I asked. Since they tried to think of themselves as adults, they didn't care for my question. 'Not really,' said the thoughtful one, 'but that doesn't mean we have to go running around out there just to prove something to you.' I knew she would bear watching.'Choose then!' I cried, as if my feelings were hurt. 'Pay no attention to anything I say.' I knew they couldn't afford not to listen to me entirely . . . they were so easily led Turning around, the group took a path that completely surprised me after all, and I followed them to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/14.PNG' usemap='#pg14-image-map' />
                <map name='pg14-image-map'>
                  <area
                    target=''
                    alt='door 10'
                    data-index='10'
                    data-title='10'
                    href='/Maze/index/10'
                    onclick = 'show('10.PNG')'
                    coords='36,272,50,264,63,262,75,254,113,236,122,238,147,298,102,316,63,331'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 43'
                    data-index='43'
                    data-title='43'
                    href='/Maze/index/43'
                    onclick = 'show('43.PNG')'
                    coords='363,208,383,212,424,217,459,214,458,234,462,253,473,274,417,272,353,269,354,238'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 24'
                    data-index='24'
                    data-title='24'
                    href='/Maze/index/24'
                    onclick = 'show('24.PNG')'
                    coords='644,212,729,230,703,299,614,276'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 15,
            Img = "../wwwroot/images/15.PNG",
            Text = ". . . room number 15. Just as we entered l heard a thump and the sound of footsteps hurrying away. Somewhere a door slammed. 'At least three of us can sit down here' said one. There were only three possible choices. Leaning on the sacrificial tripod I was suddenly moved to say, 'Perhaps these numbers relate to each other in some specific combination . . ' Immediately I regretted this act of charity . . . sometimes I think, after all these years, that I don’t really know myself. One of them thought he had worked it out and, very pleased with himself, led us into . . . ",
            Doors = string.Format(@"
              <img src='../wwwroot/images/15.PNG' usemap='#pg15-image-map' />
                <map name='pg15-image-map'>
                  <area
                    target=''
                    alt='door 30'
                    data-index='30'
                    data-title='30'
                    href='/Maze/index/30'
                    onclick = 'show('30.PNG')'
                    coords='223,129,339,171'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 37'
                    data-index='37'
                    data-title='37'
                    href='/Maze/index/37'
                    onclick = 'show('37.PNG')'
                    coords='456,127,572,171'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 3'
                    data-index='3'
                    data-title='3'
                    href='/Maze/index/3'
                    onclick = 'show('3.PNG')'
                    coords='654,117,721,103,721,165,654,169'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 16,
            Img = "../wwwroot/images/16.PNG",
            Text = ". . . a stone chamber which reminded me of my old neighbors. Of course, that was a long time ago now, but would you believe their descendants are still telling stories about me and my family to their children? Even if most of the stories are lies and exaggerations, it is immortality of a sort. As I passed in front of an open doorway a figure, crossing the hall outside, saw me and immediately ran off. 'Who was that?' they asked. 'Another visitor, to be sure.' 'Why did he run away?' 'You probably scared him.' I said, and they apparently believed me. With few regrets on my part we left for . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/16.PNG' usemap='#pg16-image-map' />
                <map name='pg16-image-map'>
                  <area
                    target=''
                    alt='door 36'
                    data-index='36'
                    data-title='36'
                    href='/Maze/index/36'
                    onclick = 'show('36.PNG')'
                    coords='60,17,118,45,115,85,108,90,58,70'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 7'
                    data-index='7'
                    data-title='7'
                    href='/Maze/index/7'
                    onclick = 'show('7.PNG')'
                    coords='669,39,726,17,728,74,670,90'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 17,
            Img = "../wwwroot/images/17.PNG",
            Text = ". . .  a room with a floor of sand. 'Amphorae’ I pronounced; empty, of course, 'This is an easier choice to make' they said. “You may think so' I muttered to myself, 'but your choices are more limited than you know.' One should never accept the obvious here. If you think of the Maze as a machine, confusion is its product, and the machine was hard at work. Ignoring my good advice they hurried into . . . ",
            Doors = string.Format(@"
              <img src='../wwwroot/images/17.PNG' usemap='#pg17-image-map' />
                <map name='pg17-image-map'>
                  <area
                    target=''
                    alt='door 6'
                    data-index='6'
                    data-title='6'
                    href='/Maze/index/6'
                    onclick = 'show('6.PNG')'
                    coords='34,315,63,300,90,301,104,306,91,355,61,361,51,336,44,321'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 45'
                    data-index='45'
                    data-title='45'
                    href='/Maze/index/45'
                    onclick = 'show('45.PNG')'
                    coords='366,28,371,24,427,23,428,28,423,34,434,41,434,57,427,77,416,91,399,104,377,93,367,79,361,61,360,44,373,35,371,31'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 33'
                    data-index='33'
                    data-title='33'
                    href='/Maze/index/33'
                    onclick = 'show('33.PNG')'
                    coords='649,90,740,67,743,142,649,150'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 18,
            Img = "../wwwroot/images/18.PNG",
            Text = ". . . a much warmer room. Shadows danced across the floor to the fire's music, 'Someone's lost his hat.' 'Are you sure it's the hat that is lost?' I asked reasonably enough. No one would answer me. Ducking behind a curtain and hurrying down a passageway we came out in . . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/18.PNG' usemap='#pg18-image-map' />
                <map name='pg18-image-map'>
                  <area
                    target=''
                    alt='door 13'
                    data-index='13'
                    data-title='13'
                    href='/Maze/index/13'
                    onclick = 'show('13.PNG')'
                    coords='363,95,452,93,458,108,458,145,367,144'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 3'
                    data-index='3'
                    data-title='3'
                    href='/Maze/index/3'
                    onclick = 'show('3.PNG')'
                    coords='667,92,753,142'
                    shape='rect' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 19,
            Img = "../wwwroot/images/19.PNG",
            Text = ". . . a shaded portico. A late afternoon sun warmed the rough blocks of stone. 'Get out of the way!' someone called. We moved into the yard, squinting at the strong light. One of them sat on a marble bench after I politely pushed some flowers aside. 'Did you pick these for me?' she asked, looking me in the eye. I had to tell her the truth, In another part of the grounds someone was singing but they couldn't make out the words. Like children they soon became restless and impatient to see something new, so we went on to  . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/19.PNG' usemap='#pg19-image-map' />
                <map name='pg19-image-map'>
                  <area
                    target=''
                    alt='door 31'
                    data-index='31'
                    data-title='31'
                    href='/Maze/index/31'
                    onclick = 'show('31.PNG')'
                    coords='179,10,187,10,283,38,284,117,177,97'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 11'
                    data-index='11'
                    data-title='11'
                    href='/Maze/index/11'
                    onclick = 'show('11.PNG')'
                    coords='333,54,394,71,393,135,333,125'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 20,
            Img = "../wwwroot/images/20.PNG",
            Text = ". . . room number 20. The ringing stopped as soon as we entered. 'What is the matter now?' I asked them. 'Too many animals for a proper house!' They walked carefully around the edges of the room. I watched with an amusement shared, I think, by the wise old tortoise. With backward looks and muttered comments about turtles they left room number 20 and entered . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/20.PNG' usemap='#pg20-image-map' />
                <map name='pg20-image-map'>
                  <area
                    target=''
                    alt='door 5'
                    data-index='5'
                    data-title='5'
                    href='/Maze/index/5'
                    onclick = 'show('5.PNG')'
                    coords='50,28,105,36,104,92,49,89'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 27'
                    data-index='27'
                    data-title='27'
                    href='/Maze/index/27'
                    onclick = 'show('27.PNG')'
                    coords='497,44,563,45,563,101,495,98'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 1'
                    data-index='1'
                    data-title='1'
                    href='/Maze/index/1'
                    onclick = 'show('1.PNG')'
                    coords='705,42,763,35,763,99,704,100'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 21,
            Img = "../wwwroot/images/21.PNG",
            Text = ". . . a yard containing shrubs trimmed in ornamental shapes. 'This,' I began, 'is called . . . ' 'We know what the name is,' they interrupted. 'Why don’t you just tell us which way to go?' 'I wasn’t referring to the plants,' I said in a huff. I refused to say anything else, leaving them to find their own way to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/21.PNG' usemap='#pg21-image-map' />
                <map name='pg21-image-map'>
                  <area
                    target=''
                    alt='door 44'
                    data-index='44'
                    data-title='44'
                    href='/Maze/index/44'
                    onclick = 'show('44.PNG')'
                    coords='77,167,155,178,131,249,98,246'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 24'
                    data-index='24'
                    data-title='24'
                    href='/Maze/index/24'
                    onclick = 'show('24.PNG')'
                    coords='427,210,481,217,462,260,438,257'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 31'
                    data-index='31'
                    data-title='31'
                    href='/Maze/index/31'
                    onclick = 'show('31.PNG')'
                    coords='685,240,688,232,726,232,728,238,715,266,692,265'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 22,
            Img = "../wwwroot/images/22.PNG",
            Text = ". . . a gaudy room that reminded me of a theatrical backdrop. Places like this are overdone, for my taste, but some people like the exotic . . . well, everyone is a critic. It's true, I am by nature extremely critical. Although my life is a lonely one I have not spared any of my guests the rigor of my judgment. . . . We all have our roles to play. This is not a bad place, really; one could spend quite some time here. However, in their restive way, the group moved on to . . . ",
            Doors = string.Format(@"
              <img src='../wwwroot/images/22.PNG' usemap='#pg22-image-map' />
                <map name='pg22-image-map'>
                  <area
                    target=''
                    alt='door 43'
                    data-index='43'
                    data-title='43'
                    href='/Maze/index/43'
                    onclick = 'show('43.PNG')'
                    coords='222,117,231,121,238,128,242,138,243,151,242,166,237,174,230,182,220,185,209,183,199,174,194,160,194,146,197,136,200,128,208,121,213,118'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 38'
                    data-index='38'
                    data-title='38'
                    href='/Maze/index/38'
                    onclick = 'show('38.PNG')'
                    coords='579,118,589,118,597,124,604,134,607,144,607,154,605,165,599,173,593,179,582,183,572,179,564,174,558,164,556,157,556,146,560,135,566,125,573,120'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 23,
            Img = "../wwwroot/images/23.PNG",
            Text = ". . . a room with three other doors. Looking out the windows my feet crushed something on the floor. 'Watch your step here.' I warned them. I'm always ready to be helpful with the less important things. 'Look at those two trees out there,' one said, looking over my shoulder, which is not easy to do. 'Must be a real wind coming up.' Now they realized that it could rain where they were going. 'We should have brought that bumbershoot with us from the coat room . . .' 'Which room was that?' 'You remember, the one with the animal. . .' I suggested that we take the door on my right and they realized they had found the door they had been seeking for so long, the entrance to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/23.PNG' usemap='#pg23-image-map' />
                <map name='pg23-image-map'>
                  <area
                    target=''
                    alt='door 28'
                    data-index='28'
                    data-title='28'
                    href='/Maze/index/28'
                    onclick = 'show('28.PNG')'
                    coords='40,102,128,154'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 8'
                    data-index='8'
                    data-title='8'
                    href='/Maze/index/8'
                    onclick = 'show('8.PNG')'
                    coords='244,102,342,155'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 45'
                    data-index='45'
                    data-title='45'
                    href='/Maze/index/45'
                    onclick = 'show('45.PNG')'
                    coords='444,102,551,155'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 19'
                    data-index='19'
                    data-title='19'
                    href='/Maze/index/19'
                    onclick = 'show('19.PNG')'
                    coords='675,87,752,73,753,124,675,131'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 24,
            Img = "../wwwroot/images/24.PNG",
            Text = ". . . a place of unlimited darkness. 'Where are the doors?' they asked nervously. 'We can't see any doors. . .' 'Be careful where you step!' said a cold voice, 'This spot is taken.' Dozens of eyes blinked at us in the Stygian gloom. By the time my uncertain visitors turned to ask me what to do I was already far away. 'There are no doors,' said the voice. 'You are here with the rest of us now . . ' Even my bellowing laughter couldn’t fill this space.",
            Doors = string.Format(@"
              <img src='../wwwroot/images/24.PNG' usemap='#pg24-image-map' />
                <map name='pg24-image-map'>
                  <area
                    target=''
                    alt='door 0'
                    data-index='0'
                    data-title='0'
                    href='/Maze/index/'
                    onclick = 'show('.PNG')'
                    coords='7,6,781,623'
                    shape='rect' />
                </map>
            </img>
            ")
          },

          new Page
          {
            PageId = 25,
            Img = "../wwwroot/images/25.PNG",
            Text = ". . . a high room with the image of a crown on the wall for everyone to see now. Though one of my parents might be low-born, the other was close to a king.... I've always felt at home here. 'Which door ought we take?' they wanted to know, I rather brusquely indicated the three doors, 'Any of these is fine for my purposes.' They were disconcerted at the apparent lack of dues. 'Perhaps in another room,' they said, leaving for . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/25.PNG' usemap='#pg25-image-map' />
                <map name='pg25-image-map'>
                  <area
                    target=''
                    alt='door 34'
                    data-index='34'
                    data-title='34'
                    href='/Maze/index/34'
                    onclick = 'show('34.PNG')'
                    coords='12,183,150,182,178,248,44,249'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 13'
                    data-index='13'
                    data-title='13'
                    href='/Maze/index/13'
                    onclick = 'show('13.PNG')'
                    coords='230,182,356,163,368,246,243,264'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 35'
                    data-index='35'
                    data-title='35'
                    href='/Maze/index/35'
                    onclick = 'show('35.PNG')'
                    coords='647,173,779,175,751,254,623,251'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 26,
            Img = "../wwwroot/images/26.PNG",
            Text = ". . . a dramatic room with four entrances and exits, 'Not enough light in here,' they remarked, 'Not very tidy either.' 'Which way now, children?' I asked in my most patronizing voice. They objected to my tone, but it distracted them from the real dues. The game usually goes as I plan it, despite the intentions of my visitors, or perhaps because of their intentions. 'What the devil is this supposed to be?' one asked. They gathered around and I realized they were dose to something. I quickly picked up the bell, ringing it loudly. 'Was this what you heard outside?' Holding their ears they ran out the door to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/26.PNG' usemap='#pg26-image-map' />
                <map name='pg26-image-map'>
                  <area
                    target=''
                    alt='door 30'
                    data-index='30'
                    data-title='30'
                    href='/Maze/index/30'
                    onclick = 'show('30.PNG')'
                    coords='60,165,76,139,88,122,97,106,103,96,115,112,123,126,128,145,132,165,134,187,58,174'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 36'
                    data-index='36'
                    data-title='36'
                    href='/Maze/index/36'
                    onclick = 'show('36.PNG')'
                    coords='184,190,191,169,199,154,208,142,224,126,235,133,250,141,260,146,270,151,286,155,292,165,296,179,299,191,191,192,184,190,185,179'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 38'
                    data-index='38'
                    data-title='38'
                    href='/Maze/index/38'
                    onclick = 'show('38.PNG')'
                    coords='497,189,500,169,506,157,515,143,524,133,537,124,546,118,557,115,565,118,575,121,585,131,591,138,598,147,606,158,609,166,612,177,614,187'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 1'
                    data-index='1'
                    data-title='1'
                    href='/Maze/index/1'
                    onclick = 'show('1.PNG')'
                    coords='666,184,666,171,667,162,671,148,674,136,678,125,683,111,688,103,697,95,701,108,708,119,715,132,722,144,727,152,728,158,735,164,733,173'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 27,
            Img = "../wwwroot/images/27.PNG",
            Text = ". . . a darkened chamber dominated by a large figure. We could see that someone had been working here recently; the entrance I had so carefully hidden had been uncovered, I made a note to return as soon as I could and fill in the hole again. The visitors were so intrigued with the entrance at the bottom of the excavation that they ignored what the figure was trying to tell them' 'Where are the workmen?' 'They must be ahead of us,' I said. 'If we hurry we can catch them . . . I mean catch up with them.' I herded the group through the door to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/27.PNG' usemap='#pg27-image-map' />
                <map name='pg27-image-map'>
                  <area
                    target=''
                    alt='door 13'
                    data-index='13'
                    data-title='13'
                    href='/Maze/index/13'
                    onclick = 'show('13.PNG')'
                    coords='173,117,196,107,206,107,189,145,189,149,186,153,180,158,179,164,124,164,129,154,124,146,132,140,139,119,149,99,163,110'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 9'
                    data-index='9'
                    data-title='9'
                    href='/Maze/index/9'
                    onclick = 'show('9.PNG')'
                    coords='384,472,379,439,397,433,420,430,431,432,436,451,428,472'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 28,
            Img = "../wwwroot/images/28.PNG",
            Text = ". . . a spacious room with a hole in the floor. A ladder led down into the shadows. Outside, leaves shook in the wind. They didn't like the look of that hole in the floor. 'Too dark down there!' they cried. 'Who knows what’s at the bottom,' They looked at me again. 'Probably a room of some kind,' I volunteered quickly, 'But you know what I say about appearances.' It would have been a relief to get outside for a while. They wanted to know if they had been here before. . . . How could I answer that? 'I have the strangest feeling of deja vu,' said one who, bolder than the rest, led us into . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/28.PNG' usemap='#pg28-image-map' />
                <map name='pg28-image-map'>
                  <area
                    target=''
                    alt='door 23'
                    data-index='23'
                    data-title='23'
                    href='/Maze/index/23'
                    onclick = 'show('23.PNG')'
                    coords='138,45,143,35,145,29,182,37,181,46,184,53,187,58,181,121,125,121,131,50'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 43'
                    data-index='43'
                    data-title='43'
                    href='/Maze/index/43'
                    onclick = 'show('43.PNG')'
                    coords='359,64,369,58,373,50,418,49,421,58,429,62,435,66,434,121,360,121'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 45'
                    data-index='45'
                    data-title='45'
                    href='/Maze/index/45'
                    onclick = 'show('45.PNG')'
                    coords='618,57,623,51,623,40,656,31,660,41,672,50,678,114,673,121,623,121'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 32'
                    data-index='32'
                    data-title='32'
                    href='/Maze/index/32'
                    onclick = 'show('32.PNG')'
                    coords='281,429,291,420,310,417,351,406,373,427,360,455,347,462,329,464,316,468,301,478'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 29,
            Img = "../wwwroot/images/29.PNG",
            Text = ". . . a much smaller room. A person with a white staff turned to face us. His associate shrugged, not an easy thing to do in his position, and went back to what he had been doing. 'Look, look,' said the person with the staff 'This is very important . . . ' I snatched the paper from his hand and tore it to pieces. 'How will he find his way without directions?' the group wanted to know. 'Don't worry,' said the man, 'here blindness is no disadvantage.' I hurried my visitors out as quickly as I could to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/29.PNG' usemap='#pg29-image-map' />
                <map name='pg29-image-map'>
                  <area
                    target=''
                    alt='door 8'
                    data-index='8'
                    data-title='8'
                    href='/Maze/index/8'
                    onclick = 'show('8.PNG')'
                    coords='56,210,85,305'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 40'
                    data-index='40'
                    data-title='40'
                    href='/Maze/index/40'
                    onclick = 'show('40.PNG')'
                    coords='164,178,202,171,204,253,164,263'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 35'
                    data-index='35'
                    data-title='35'
                    href='/Maze/index/35'
                    onclick = 'show('35.PNG')'
                    coords='452,160,537,220'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 2'
                    data-index='2'
                    data-title='2'
                    href='/Maze/index/2'
                    onclick = 'show('2.PNG')'
                    coords='608,159,643,164,643,242,605,228,607,194'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 17'
                    data-index='17'
                    data-title='17'
                    href='/Maze/index/17'
                    onclick = 'show('17.PNG')'
                    coords='368,369,419,369,421,411,356,414,357,404,364,393,369,379'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 30,
            Img = "../wwwroot/images/30.PNG",
            Text = ". . . room number 30. 'What a beautiful door ... the others are so plain,' said one. 'It's meant to influence our decision,' said another. 'Perhaps this has been done so we will not choose this door,' said the thoughtful one. They wanted to know what the letters meant. Obviously they meant something, and I said so. 'Yes, but. . . why 'O' and 'U'? What special significance can they have for us?' The more confused they became, the more I enjoyed it. No matter how many times I've been through this I’m always fascinated. Leaving the room and all that it contained behind us, we entered . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/30.PNG' usemap='#pg30-image-map' />
                <map name='pg30-image-map'>
                  <area
                    target=''
                    alt='door 42'
                    data-index='42'
                    data-title='42'
                    href='/Maze/index/42'
                    onclick = 'show('42.PNG')'
                    coords='130,32,186,48,186,102,130,96'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 34'
                    data-index='34'
                    data-title='34'
                    href='/Maze/index/34'
                    onclick = 'show('34.PNG')'
                    coords='331,87,334,73,343,58,354,47,370,36,388,31,403,29,419,32,434,37,449,46,464,62,473,78,475,86,410,87'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 5'
                    data-index='5'
                    data-title='5'
                    href='/Maze/index/5'
                    onclick = 'show('5.PNG')'
                    coords='616,46,666,31,667,92,616,98,617,71'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 15'
                    data-index='15'
                    data-title='15'
                    href='/Maze/index/15'
                    onclick = 'show('15.PNG')'
                    coords='700,22,754,5,776,6,777,79,701,88'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 31,
            Img = "../wwwroot/images/31.PNG",
            Text = ". . . a melancholy little courtyard surrounded by a brick wall too high to see over. A dead tree lifted its bone-white branches to a sky filling with gray clouds. 'Those doors look very strange,' they said. 'You should say, 'They look very strangely'' I corrected, 'They seem to be watching us. . .' A sudden gust of wind made the branches clatter against each other like old boards. Dead leaves began to gather at our feet. Shivering in the wind we managed to push open one of the heavy doors and make our way to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/31.PNG' usemap='#pg31-image-map' />
                <map name='pg31-image-map'>
                  <area
                    target=''
                    alt='door 44'
                    data-index='44'
                    data-title='44'
                    href='/Maze/index/44'
                    onclick = 'show('44.PNG')'
                    coords='57,164,66,160,71,145,75,150,82,150,83,144,98,144,111,148,122,150,134,157,136,166,147,168,149,180,157,188,162,197,138,195,138,190,101,183,92,184,51,177'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 19'
                    data-index='19'
                    data-title='19'
                    href='/Maze/index/19'
                    onclick = 'show('19.PNG')'
                    coords='267,212,274,204,275,193,280,197,287,192,302,193,319,198,329,204,327,210,335,212,337,220,342,230,315,224,291,220,265,215'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 21'
                    data-index='21'
                    data-title='21'
                    href='/Maze/index/21'
                    onclick = 'show('21.PNG')'
                    coords='620,198,626,187,632,180,633,164,639,169,645,167,647,158,667,148,690,145,703,145,707,152,714,155,716,145,722,162,732,167,737,178,695,186,690,183,645,191,645,195'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 32,
            Img = "../wwwroot/images/32.PNG",
            Text = ". . . a large square room with a hole rudely broken through one wall. It must have taken a great deal of strength to pull the heavy stones out of position. The symmetry was also disturbed by the apparent loss of one of the room's statues. My visitors thought a thief had broken into the room, removed the figure, and made away with it. This, of course, was one explanation. 'Another one!' they cried, 'You mean another representative of the animal kingdom?' I asked, “What is a bird like that doing here?' 'Roosting, evidently.' Their attitude was really beginning to irritate me. I have come to think of all the inhabitants of this House as members of my little kingdom. People can be so arrogant. . . in a very real way we are all of us animals, at least in part. I wouldn't answer any more of their questions so we left this room to enter . . . ",
            Doors = string.Format(@"
              <img src='../wwwroot/images/32.PNG' usemap='#pg32-image-map' />
                <map name='pg32-image-map'>
                  <area
                    target=''
                    alt='door 11'
                    data-index='11'
                    data-title='11'
                    href='/Maze/index/11'
                    onclick = 'show('11.PNG')'
                    coords='57,146,134,155,126,221,46,216'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 6'
                    data-index='6'
                    data-title='6'
                    href='/Maze/index/6'
                    onclick = 'show('6.PNG')'
                    coords='376,96,390,99,401,100,416,99,425,93,430,100,430,122,425,133,419,144,406,157,399,165,387,145,379,126'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 28'
                    data-index='28'
                    data-title='28'
                    href='/Maze/index/28'
                    onclick = 'show('28.PNG')'
                    coords='769,300,770,308,770,370,717,345,717,283'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 16'
                    data-index='16'
                    data-title='16'
                    href='/Maze/index/16'
                    onclick = 'show('16.PNG')'
                    coords='203,372,265,327,287,453,242,538,237,541'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 33,
            Img = "../wwwroot/images/33.PNG",
            Text = ". . . the room with no floor. They crowded each other on the narrow ledge, The bold one ventured out to the center. Realizing that they could see all of the signs only from the center of the room, several wanted to turn back. With exaggerated caution, considering their predicament, they finally reached the door they wanted and eventually found themselves in . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/33.PNG' usemap='#pg33-image-map' />
                <map name='pg33-image-map'>
                  <area
                    target=''
                    alt='door 3'
                    data-index='3'
                    data-title='3'
                    href='/Maze/index/3'
                    onclick = 'show('3.PNG')'
                    coords='98,169,107,144,112,117,106,113,131,50,150,174,98,179,100,173'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 35'
                    data-index='35'
                    data-title='35'
                    href='/Maze/index/35'
                    onclick = 'show('35.PNG')'
                    coords='458,166,515,63,571,166'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 7'
                    data-index='7'
                    data-title='7'
                    href='/Maze/index/7'
                    onclick = 'show('7.PNG')'
                    coords='642,173,666,53,682,114,676,117,676,134,680,147,687,160,691,168,682,173,681,178'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 34,
            Img = "../wwwroot/images/34.PNG",
            Text = ". . . a middle-class drawing room or parlor. It was amazing how much more comfortable they felt in these surroundings. Everyone sat down, some on the floor, and chatted about where they had been and where they should go. 'Magpies!' I said to myself. 'Not a real thought in their heads.' They were so much at ease they almost missed what the room was telling them altogether. They finally got the message, which I thought was pretty obvious, and we went on to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/34.PNG' usemap='#pg34-image-map' />
                <map name='pg34-image-map'>
                  <area
                    target=''
                    alt='door 10'
                    data-index='10'
                    data-title='10'
                    href='/Maze/index/10'
                    onclick = 'show('10.PNG')'
                    coords='39,11,55,11,73,21,89,24,99,26,103,30,108,56,114,72,121,82,82,77,71,75,56,75,48,62,40,44'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 25'
                    data-index='25'
                    data-title='25'
                    href='/Maze/index/25'
                    onclick = 'show('25.PNG')'
                    coords='225,77,228,71,231,67,229,59,269,47,296,36,305,57,309,77,309,88,234,109'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 35,
            Img = "../wwwroot/images/35.PNG",
            Text = ". . . what appeared to be someone's basement. One of them sank gratefully down on an old couch which promptly collapsed, I tried to hide my smile. 'A totem, or tribal fetish,' said one, walking around the center of the room. 'It could be a work of art,' suggested another. 'Perhaps it's a signal to us,' the thoughtful one said. 'A warning or direction?' 'Not much help when there is only one way to go,' put in another. 'I still think it’s a signal.' 'Yes,' I said right away, 'I'm sure you’re right.' She was immediately suspicious. Still, with no real choice to make, we left the thing standing alone in light and silence, and went into . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/35.PNG' usemap='#pg35-image-map' />
                <map name='pg35-image-map'>
                  <area
                    target=''
                    alt='door 33'
                    data-index='33'
                    data-title='33'
                    href='/Maze/index/33'
                    onclick = 'show('33.PNG')'
                    coords='38,101,186,140'
                    shape='rect' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 36,
            Img = "../wwwroot/images/36.PNG",
            Text = ". . . an old and ruinous part of the House. Turning a corner the music we had been hearing became louder and at last we saw the musicians themselves. They were so involved they failed to hear us. The music was suited to the scene— a moody, romantic melody. We stopped to listen and I admit that I, too, was affected by the sound as well as by the spectacle of the masked players. One of the visitors noticed me listening. 'Beautiful music, don't you think?' 'It's not bad,' I said stiffly. 'The viol brings the right sense of warmth to the piece, but the guitarist is overplaying his part. Still, he adds a certain plangent brio to an otherwise introspective composition . . .' Unwilling to interrupt the concert we slipped past the musicians into the door to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/36.PNG' usemap='#pg36-image-map' />
                <map name='pg36-image-map'>
                  <area
                    target=''
                    alt='door 7'
                    data-index='7'
                    data-title='7'
                    href='/Maze/index/7'
                    onclick = 'show('7.PNG')'
                    coords='52,26,107,40,108,88,50,83'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 16'
                    data-index='16'
                    data-title='16'
                    href='/Maze/index/16'
                    onclick = 'show('16.PNG')'
                    coords='222,60,309,60,310,99,226,100'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 37,
            Img = "../wwwroot/images/37.PNG",
            Text = ". . . a long, open room with no roof. 'What is going on here?' they wondered. 'Sometimes, important messages are couched in ambiguous terms,' I said. 'That net may help you catch the answer to your question,' They looked doubtful. 'We must look at this from all sides before we make a decision,' At last, they were learning. They really couldn't decide which way to go; half of them wanted to go one way, half another. They were close to splitting up when there was a rattling sound and one of the doors was shaken from the other side. They all stopped talking and moved doser together. They soon agreed on a direction and we departed for . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/37.PNG' usemap='#pg37-image-map' />
                <map name='pg37-image-map'>
                  <area
                    target=''
                    alt='door 15'
                    data-index='15'
                    data-title='15'
                    href='/Maze/index/15'
                    onclick = 'show('15.PNG')'
                    coords='40,120,50,106,63,93,84,85,112,83,134,86,149,95,164,112,168,129,170,142,33,142'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 10'
                    data-index='10'
                    data-title='10'
                    href='/Maze/index/10'
                    onclick = 'show('10.PNG')'
                    coords='229,143,242,116,260,98,280,89,301,87,319,89,335,95,348,105,363,121,369,140,344,143'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 42'
                    data-index='42'
                    data-title='42'
                    href='/Maze/index/42'
                    onclick = 'show('42.PNG')'
                    coords='419,143,421,127,429,113,438,101,450,89,464,82,478,78,501,76,518,80,535,89,550,100,558,112,567,129,568,144'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 20'
                    data-index='20'
                    data-title='20'
                    href='/Maze/index/20'
                    onclick = 'show('20.PNG')'
                    coords='623,143,625,120,637,99,663,80,690,74,716,76,742,89,756,102,765,115,770,134,771,146'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 38,
            Img = "../wwwroot/images/38.PNG",
            Text = ". . . a narrow space where one wall boasted half-finished carvings and another some sort of carnival poster. There was a little confusion as we made our entrance but we soon sorted ourselves out. It was impossible to climb up the slippery slide and another door wouldn’t open for us, so after emptying the pebbles from our shoes, we marched on to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/38.PNG' usemap='#pg38-image-map' />
                <map name='pg38-image-map'>
                  <area
                    target=''
                    alt='door 40'
                    data-index='40'
                    data-title='40'
                    href='/Maze/index/40'
                    onclick = 'show('40.PNG')'
                    coords='352,104,515,147'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 22'
                    data-index='22'
                    data-title='22'
                    href='/Maze/index/22'
                    onclick = 'show('22.PNG')'
                    coords='584,118,645,101,645,159,584,169'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 43'
                    data-index='43'
                    data-title='43'
                    href='/Maze/index/43'
                    onclick = 'show('43.PNG')'
                    coords='686,89,783,59,785,144,686,153'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 39,
            Img = "../wwwroot/images/39.PNG",
            Text = ". . . what looked like a combination wine cellar and junk room. Someone had been working here as well, 'This is more to my taste,' said one, dusting off some labels. All the bottles turned out to be empty. 'I hear someone hammering.' said one, 'No, that’s a chopping sound.' said another. None of them heard the feint jingling that came from behind the wall. 'I don't hear anything,' I said loudly and, with as much commotion as possible, hurried them out of the room to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/39.PNG' usemap='#pg39-image-map' />
                <map name='pg39-image-map'>
                  <area
                    target=''
                    alt='door 11'
                    data-index='11'
                    data-title='11'
                    href='/Maze/index/11'
                    onclick = 'show('11.PNG')'
                    coords='43,59,122,65,122,148,44,164'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 4'
                    data-index='4'
                    data-title='4'
                    href='/Maze/index/4.PNG'
                    onclick = 'show('4.PNG')'
                    coords='192,71,246,76,244,128,193,136'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 12'
                    data-index='12'
                    data-title='12'
                    href='/Maze/index/12'
                    onclick = 'show('12.PNG')'
                    coords='553,69,609,61,609,136,553,130'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 40,
            Img = "../wwwroot/images/40.PNG",
            Text = ". . . the foundation of the Maze, Deep underground stones had been carved and fitted; passages opened in the natural rock, 'These symbols are quite unusual' said one. 'They seem to be primitive signs. . .' 'Do you know what signs?' I asked him. 'Oh, you know . . . wind and water, hills and planets.' It was surprising that he could identify any of the symbols, but I was relieved that he couldn’t read them correctly. Choosing more or less at random they went through a passageway to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/40.PNG' usemap='#pg40-image-map' />
                <map name='pg40-image-map'>
                  <area
                    target=''
                    alt='door 11'
                    data-index='11'
                    data-title='11'
                    href='/Maze/index/11'
                    onclick = 'show('11.PNG')'
                    coords='27,50,90,70,124,84,139,93,105,183,15,153,15,108'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 66'
                    data-index='6'
                    data-title='6'
                    href='/Maze/index/6'
                    onclick = 'show('6.PNG')'
                    coords='228,151,318,135,324,151,324,202,235,218'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 38'
                    data-index='38'
                    data-title='38'
                    href='/Maze/index/38'
                    onclick = 'show('38.PNG')'
                    coords='431,158,445,158,472,167,477,172,488,176,487,229,428,215'
                    shape='poly' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 41,
            Img = "../wwwroot/images/41.PNG",
            Text = ". . . a room with a special piece of furniture I thought might appeal to my guests. 'How can we trust that thing?' one remarked. 'Who knows where it ends up . . .' I knew, naturally, but that wasn't the point. They were pretty sure of themselves, and went right on to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/41.PNG' usemap='#pg41-image-map' />
                <map name='pg41-image-map'>
                <area
                  target=''
                  alt='door 1'
                  data-index='1'
                  data-title='1'
                  href='/Maze/index/1'
                  onclick = 'show('1.PNG')'
                  coords='85,11,122,12,144,22,140,33,142,49,140,64,133,77,113,94,100,78,92,65,84,51,82,35,86,18'
                  shape='poly' />

                <area
                  target=''
                  alt='door 10'
                  data-index='10'
                  data-title='10'
                  href='/Maze/index/10'
                  onclick = 'show('10.PNG')'
                  coords='353,51,446,51,444,58,444,78,442,92,437,103,425,112,409,122,401,128,388,117,374,111,361,105,357,89,357,60'
                  shape='poly' />

                <area
                  target=''
                  alt='door 38'
                  data-index='38'
                  data-title='38'
                  href='/Maze/index/38'
                  onclick = 'show('38.PNG')'
                  coords='651,25,678,12,720,13,724,34,724,56,718,68,707,79,697,87,687,104,677,94,665,89,657,79,652,67,651,50,652,36'
                  shape='poly' />
              </map>
            </img>
            ")
          },

          new Page
          {
            PageId = 42,
            Img = "../wwwroot/images/42.PNG",
            Text = ". . . the next room. In one comer a savage animal appeared ready to leap out, roaring, rending with tusk and claw . . . but it was only a bit of taxidermy after all. I suggested they might wish to hang up their coats before going on. 'How will we find them?' one asked. 'We might not pass through here again.' I assured them I would help them to return. 'You can count on me,' I said sincerely. Still, they wouldn't leave anything behind. Opening one of the doors we made our way to . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/42.PNG' usemap='#pg42-image-map' />
                <map name='pg42-image-map'>
                  <area
                    target=''
                    alt='door 22'
                    data-index='22'
                    data-title='22'
                    href='/Maze/index/22'
                    onclick = 'show('22.PNG')'
                    coords='43,13,117,34,117,119,43,110'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 30'
                    data-index='30'
                    data-title='30'
                    href='/Maze/index/30'
                    onclick = 'show('30.PNG')'
                    coords='153,48,205,66,208,129,156,122'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 4'
                    data-index='4'
                    data-title='4'
                    href='/Maze/index/4.PNG'
                    onclick = 'show('4.PNG')'
                    coords='289,79,390,136'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 25'
                    data-index='25'
                    data-title='25'
                    href='/Maze/index/25'
                    onclick = 'show('25.PNG')'
                    coords='467,79,574,136'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 37'
                    data-index='37'
                    data-title='37'
                    href='/Maze/index/37'
                    onclick = 'show('37.PNG')'
                    coords='650,76,754,134'
                    shape='rect' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 43,
            Img = "../wwwroot/images/43.PNG",
            Text = ". . . a great hall, dominated by the entrance to room 22. The face over the door had a sly look. 'Is it good or bad to have only two choices?' they wanted to know. It was, predictably enough, neither 'good' nor 'bad'. These people just didn't know how to phrase a meaningful question. You have to be very particular in this House, We went on to  . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/43.PNG' usemap='#pg43-image-map' />
                <map name='pg43-image-map'>
                  <area
                    target=''
                    alt='door 22'
                    data-index='22'
                    data-title='22'
                    href='/Maze/index/22'
                    onclick = 'show('22.PNG')'
                    coords='367,19,378,14,390,11,412,12,419,19,425,13,431,19,432,28,427,37,423,45,417,54,421,61,412,67,403,58,394,61,382,69,373,62,379,54,372,38'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 38'
                    data-index='38'
                    data-title='38'
                    href='/Maze/index/38'
                    onclick = 'show('38.PNG')'
                    coords='359,447,422,520'
                    shape='rect' />
                </map>
              </img>
            ")
          },

          new Page
          {
            PageId = 44,
            Img = "../wwwroot/images/44.PNG",
            Text = ". . . a courtyard of palms and statues. The trees waved to each other in the breeze. 'Who left the door open?' they wanted to know. 'We came in that way,' I offered, but they were convinced we had entered by another door entirely. They vanished through the wall and I followed them to . . .",
            Doors = string.Format(@"
            <img src='../wwwroot/images/44.PNG' usemap='#pg44-image-map' />
              <map name='pg44-image-map'>
                <area
                  target=''
                  alt='door 21'
                  data-index='21'
                  data-title='21'
                  href='/Maze/index/21'
                  onclick = 'show('21.PNG')'
                  coords='259,204,263,191,275,179,285,173,299,168,309,168,320,172,330,177,336,183,341,192,348,201,351,215,345,218,256,219'
                  shape='poly' />

                <area
                  target=''
                  alt='door 18'
                  data-index='18'
                  data-title='18'
                  href='/Maze/index/18'
                  onclick = 'show('18.PNG')'
                  coords='632,190,647,175,666,167,679,167,695,172,704,183,711,196,716,219,633,219'
                  shape='poly' />
              </map>
            </img>
          ")
          },

          new Page
          {
            PageId = 45,
            Img = "../wwwroot/images/45.PNG",
            Text = ". . . the room at the center of the Maze. My guests thought that whoever lived here was a careless person, to leave so many things around. They were wrong. There was really only one thing for them to find: the Riddle of the Maze. They demanded that I show it to them. 'Do you think it is written on the wall for all to see? It is hidden here, somewhere, perhaps throughout the room. As far as you are concerned, what the Maze teaches can be learned in every room.' They looked and looked . . . every group is the same, 'Now,' I said, after a last look around, 'we must find our way back out.' Leaving the center of the Maze we found ourselves in . . .",
            Doors = string.Format(@"
              <img src='../wwwroot/images/45.PNG' usemap='#pg45-image-map' />
                <map name='pg45-image-map'>
                  <area
                    target=''
                    alt='door 28'
                    data-index='28'
                    data-title='28'
                    href='/Maze/index/28'
                    onclick = 'show('28.PNG')'
                    coords='46,67,112,62,114,119,48,133'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 17'
                    data-index='17'
                    data-title='17'
                    href='/Maze/index/17'
                    onclick = 'show('17.PNG')'
                    coords='166,57,210,53,211,102,169,112'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 36'
                    data-index='36'
                    data-title='36'
                    href='/Maze/index/36'
                    onclick = 'show('36.PNG')'
                    coords='349,52,464,97'
                    shape='rect' />

                  <area
                    target=''
                    alt='door 19'
                    data-index='19'
                    data-title='19'
                    href='/Maze/index/19'
                    onclick = 'show('19.PNG')'
                    coords='601,97,601,50,647,54,647,107'
                    shape='poly' />

                  <area
                    target=''
                    alt='door 23'
                    data-index='23'
                    data-title='23'
                    href='/Maze/index/23'
                    onclick = 'show('23.PNG')'
                    coords='699,58,762,63,761,127,699,116'
                    shape='poly' />
                </map>
              </img>
            ")
          }
        );
    }

    public DbSet<Page> Pages { get; set; }

  }
}