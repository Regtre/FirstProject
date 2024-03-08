using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstProject.Migrations
{
    /// <inheritdoc />
    public partial class PopulatedMovieModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Movies (Title,Author, Genre, ReleaseDate, DateAdded, NumberInStock ) values ('Hangover', 'Todd Phillips', 1, '2009-09-06', '2016-04-04',5)");
            migrationBuilder.Sql("insert into Movies (Title,Author, Genre, ReleaseDate, DateAdded, NumberInStock ) values ('Die Hard', 'Todd Phillips', 2, '2019-09-06', '2016-04-04',4)");
            migrationBuilder.Sql("insert into Movies (Title,Author, Genre, ReleaseDate, DateAdded, NumberInStock ) values ('The Terminator', 'Todd Phillips', 2, '2011-09-06', '2016-04-04',9)");
            migrationBuilder.Sql("insert into Movies (Title,Author, Genre, ReleaseDate, DateAdded, NumberInStock ) values ('Titanic', 'Todd Phillips', 7, '2006-09-06', '2016-04-04',2)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
