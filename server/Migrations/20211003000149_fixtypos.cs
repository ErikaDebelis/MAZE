using Microsoft.EntityFrameworkCore.Migrations;

namespace Maze.Migrations
{
    public partial class fixtypos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 4,
                column: "Doors",
                value: "\r\n              <img src='../wwwroot/images/4.PNG' usemap='#pg4-image-map' >\r\n                <map name='pg4-image-map'>\r\n                  <area\r\n                    target=''\r\n                    alt='door 44'\r\n                    data-index='44'\r\n                    data-title='44'\r\n                    href='/Maze/index/44'\r\n                    onclick = 'show('44.PNG')'\r\n                    coords='74,41,53,115,163,137,179,82'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 29'\r\n                    data-index='29'\r\n                    data-title='29'\r\n                    href='/Maze/index/29'\r\n                    onclick = 'show('29.PNG')'\r\n                    coords='231,100,218,148,264,159,277,118'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 15'\r\n                    data-index='15'\r\n                    data-title='15'\r\n                    href='/Maze/index/15'\r\n                    onclick = 'show('15.PNG')'\r\n                    coords='300,125,288,164,312,168,322,136'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 11'\r\n                    data-index='11'\r\n                    data-title='11'\r\n                    href='/Maze/index/11'\r\n                    onclick = 'show('11.PNG')'\r\n                    coords='371,148,442,183'\r\n                    shape='rect' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 16'\r\n                    data-index='16'\r\n                    data-title='16'\r\n                    href='/Maze/index/16'\r\n                    onclick = 'show('16.PNG')'\r\n                    coords='492,135,502,170,527,164,515,125'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 24'\r\n                    data-index='24'\r\n                    data-title='24'\r\n                    href='/Maze/index/24'\r\n                    onclick = 'show('24.PNG')'\r\n                    coords='540,118,553,161,598,153,583,102'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 43'\r\n                    data-index='43'\r\n                    data-title='43'\r\n                    href='/Maze/index/43'\r\n                    onclick = 'show('43.PNG')'\r\n                    coords='634,81,655,142,766,122,746,42'\r\n                    shape='poly' />\r\n                </map>\r\n              </img>\r\n              ");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 6,
                column: "Text",
                value: ". . . a gloomy, cavelike place far underground, Even I was oppressed by the weight that hung over our heads. A very small hole, high above, admitted a feeble light. Standing in the light one of them put his hand out. 'I think it may be raining out there . . .' They didn't like the look of the place. 'You continue to judge everything by the way it looks!' I cried, exasperated by their timidity. I knew I shouldn't have said anything. If you think of all the deceptions practiced in my family, particularly on my father . . . We went down the only way open to us and came to . . .");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 4,
                column: "Doors",
                value: "\r\n              <img src='../wwwroot/images/4.PNG' usemap='#pg4-image-map' >\r\n                <map name='pg4-image-map'>\r\n                  <area\r\n                    target=''\r\n                    alt='door 44'\r\n                    data-index='44'\r\n                    data-title='44'\r\n                    href='/Maze/index/44'\r\n                    onclick = 'show('44.PNG')'\r\n                    coords='74,41,53,115,163,137,179,82'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 29'\r\n                    data-index='29'\r\n                    data-title='29'\r\n                    href='/Maze/index/29'\r\n                    onclick = 'show('29.PNG')'\r\n                    coords='231,100,218,148,264,159,277,118'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 15'\r\n                    data-index='15'\r\n                    data-title='15'\r\n                    href='/Maze/index/15'\r\n                    onclick = 'show('15.PNG')'\r\n                    coords='300,125,288,164,312,168,322,136'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 11'\r\n                    data-index='11'\r\n                    data-title='11'\r\n                    href='/Maze/index/11'\r\n                    onclick = 'show('11.PNG')'\r\n                    coords='371,148,442,183'\r\n                    shape='rect' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 16'\r\n                    data-index='16'\r\n                    data-title='16'\r\n                    href='/Maze/index/16'\r\n                    onclick = 'show('16.PNG')'\r\n                    coords='492,135,502,170,527,164,515,125'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 24'\r\n                    data-index='24'\r\n                    data-title='24'\r\n                    href='/Maze/index/24'\r\n                    onclick = 'show('24.PNG')'\r\n                    coords='540,118,553,161,598,153,583,102'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 43'\r\n                    data-index='43'\r\n                    data-title='43'\r\n                    href='/Maze/index/dbcontext43'\r\n                    onclick = 'show('43.PNG')'\r\n                    coords='634,81,655,142,766,122,746,42'\r\n                    shape='poly' />\r\n                </map>\r\n              </img>\r\n              ");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 6,
                column: "Text",
                value: ". . . a gloomy, cavelike place far underground, Even I was oppressed by the weight that hung over our heads. A very small hole, high above, admitted a feeble light. Standing in the light one ofthem put his hand out. 'I think it may be raining out there . . .' They didn't like the look of the place. 'You continue to judge everything by the way it looks!' I cried, exasperated by their timidity. I knew I shouldn't have said anything. If you think of all the deceptions practiced in my family, particularly on my father . . . We went down the only way open to us and came to . . .");
        }
    }
}
