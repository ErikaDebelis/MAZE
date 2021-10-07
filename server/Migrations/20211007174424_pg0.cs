using Microsoft.EntityFrameworkCore.Migrations;

namespace Maze.Migrations
{
    public partial class pg0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 24,
                column: "Doors",
                value: "\r\n              <img src='/images/24.PNG' usemap='#pg24-image-map' />\r\n                <map name='pg24-image-map'>\r\n                  <area\r\n                    target=''\r\n                    alt='door 0'\r\n                    data-index='0'\r\n                    data-title='46'\r\n                    href='/pageControl/'\r\n                    coords='7,6,781,623'\r\n                    shape='rect' />\r\n                </map>\r\n            </img>\r\n            ");

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "PageId", "Doors", "Img", "Text" },
                values: new object[] { 46, "\r\n              <img src='/images/0.PNG' usemap='#pg0-image-map' />\r\n                <map name='pg0-image-map'>\r\n                  <area\r\n                    target=''\r\n                    alt='door 1'\r\n                    data-index=''\r\n                    data-title='1'\r\n                    href='/pageControl/'\r\n                    coords='7,6,781,623'\r\n                    shape='rect' />\r\n                </map>\r\n            </img>\r\n            ", "/images/0.PNG", "The Maze. I met them at the gate though usually I wait inside. Preoccupied with their own thoughts, impatient, like so many children, they didn't see who I really was. They never noticed my crown, my pain, the fire in my eyes.Like all the others they think the Maze was made for them; actually, it is the other way around. They think I am some poet who will lead them through the symbols and spaces of this Underworld. They think I will teach the, lessons. They should call me Cerberus. . . . I am the lesson. The monstrous walls rise up and run away as far as the human eye can see, circling and dividing. Which half is the Maze? Even I get lost. It changes- somethings slowly, imperceptibly. . . sometimes suddenly. This House is not only made of stone and mortar, wood and paint; it is made of time and mystery, hope and fear. Construction never stops. I take some pride in my role as architect. They think I will guide them to the center. Perhaps I will. . . . The sun was very hot. Together we walked through the gate into. . . " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 46);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "PageId",
                keyValue: 24,
                column: "Doors",
                value: "\r\n              <img src='/images/24.PNG' usemap='#pg24-image-map' />\r\n                <map name='pg24-image-map'>\r\n                  <area\r\n                    target=''\r\n                    alt='door 0'\r\n                    data-index='0'\r\n                    data-title='0'\r\n                    href='/pageControl/'\r\n                    coords='7,6,781,623'\r\n                    shape='rect' />\r\n                </map>\r\n            </img>\r\n            ");
        }
    }
}
