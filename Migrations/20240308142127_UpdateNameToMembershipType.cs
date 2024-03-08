using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameToMembershipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("update MembershipType set Name = 'Pay as You Go' where Id=1");
            migrationBuilder.Sql("update MembershipType set Name = 'Monthly' where Id=2");
            migrationBuilder.Sql("update MembershipType set Name = 'Quarterly' where Id=3");
            migrationBuilder.Sql("update MembershipType set Name = 'Annualy' where Id=4");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
