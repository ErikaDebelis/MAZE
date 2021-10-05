using Microsoft.EntityFrameworkCore.Migrations;

namespace Maze.Migrations
{
    public partial class chngOnClick : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 1,
                column: "Doors",
                value: "\r\n              <img src='/images/1.PNG' usemap='#pg1-image-map' >\r\n                <map name='pg1-image-map'>\r\n                  <area\r\n                    target=''\r\n                    alt='door 20'\r\n                    data-index=''\r\n                    data-title='20'\r\n                    onclick = 'componentDidMount(20)'\r\n                    coords='223,84,299,117'\r\n                    shape='rect' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 26'\r\n                    data-index=''\r\n                    data-title='26'\r\n                    onclick = 'componentDidMount(26)'\r\n                    coords='431,81,510,117'\r\n                    shape='rect' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 41'\r\n                    data-index=''\r\n                    data-title='41'\r\n                    onclick = 'componentDidMount(41)'\r\n                    coords='586,115,649,113,641,71,585,78'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 21'\r\n                    data-index=''\r\n                    data-title='21'\r\n                    onclick = 'componentDidMount(21)'\r\n                    coords='698,61,701,110,772,105,767,55'\r\n                    shape='poly' />\r\n                </map>\r\n              </img>\r\n            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 1,
                column: "Doors",
                value: "\r\n              <img src='/images/1.PNG' usemap='#pg1-image-map' >\r\n                <map name='pg1-image-map'>\r\n                  <area\r\n                    target=''\r\n                    alt='door 20'\r\n                    data-index=''\r\n                    data-title='20'\r\n                    href='/Maze/index/20'\r\n                    onclick = 'show('20.PNG')'\r\n                    coords='223,84,299,117'\r\n                    shape='rect' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 26'\r\n                    data-index=''\r\n                    data-title='26'\r\n                    href='/Maze/index/26'\r\n                    onclick = 'show('26.PNG')'\r\n                    coords='431,81,510,117'\r\n                    shape='rect' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 41'\r\n                    data-index=''\r\n                    data-title='41'\r\n                    href='/Maze/index/41'\r\n                    onclick = 'show('41.PNG')'\r\n                    coords='586,115,649,113,641,71,585,78'\r\n                    shape='poly' />\r\n\r\n                  <area\r\n                    target=''\r\n                    alt='door 21'\r\n                    data-index=''\r\n                    data-title='21'\r\n                    href='/Maze/index/21'\r\n                    onclick = 'show('21.PNG')'\r\n                    coords='698,61,701,110,772,105,767,55'\r\n                    shape='poly' />\r\n                </map>\r\n              </img>\r\n            ");
        }
    }
}
