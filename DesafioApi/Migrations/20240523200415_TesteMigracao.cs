using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioApi.Migrations
{
    /// <inheritdoc />
    public partial class TesteMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    email = table.Column<string>(type: "text", nullable: false),
                    gender = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    firstname = table.Column<string>(type: "text", nullable: false),
                    lastname = table.Column<string>(type: "text", nullable: false),
                    streetnumber = table.Column<int>(type: "integer", nullable: false),
                    streetname = table.Column<string>(type: "text", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    statelocation = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    postcode = table.Column<string>(type: "text", nullable: false),
                    latitude = table.Column<string>(type: "text", nullable: false),
                    longitude = table.Column<string>(type: "text", nullable: false),
                    timezoneoffset = table.Column<string>(type: "text", nullable: false),
                    timezonedescription = table.Column<string>(type: "text", nullable: false),
                    uuidlogin = table.Column<string>(type: "text", nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    passwordlogin = table.Column<string>(type: "text", nullable: false),
                    salt = table.Column<string>(type: "text", nullable: false),
                    md5 = table.Column<string>(type: "text", nullable: false),
                    sha1 = table.Column<string>(type: "text", nullable: false),
                    sha256 = table.Column<string>(type: "text", nullable: false),
                    dateofbirth = table.Column<string>(type: "text", nullable: false),
                    age = table.Column<int>(type: "integer", nullable: false),
                    dateregistered = table.Column<string>(type: "text", nullable: false),
                    ageregistered = table.Column<int>(type: "integer", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    cell = table.Column<string>(type: "text", nullable: false),
                    nameid = table.Column<string>(type: "text", nullable: false),
                    valueid = table.Column<string>(type: "text", nullable: false),
                    picturelarge = table.Column<string>(type: "text", nullable: false),
                    picturemedium = table.Column<string>(type: "text", nullable: false),
                    thumbnail = table.Column<string>(type: "text", nullable: false),
                    nat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.email);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
