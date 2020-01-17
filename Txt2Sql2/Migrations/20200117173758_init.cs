using Microsoft.EntityFrameworkCore.Migrations;

namespace Txt2Sql2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gpds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAS_ID = table.Column<int>(nullable: false),
                    SRC_CD = table.Column<string>(nullable: true),
                    ACCTG_BASIS_CD = table.Column<string>(nullable: true),
                    REF_ID = table.Column<string>(nullable: true),
                    CMPNY_CD = table.Column<string>(nullable: true),
                    EAS_ACCT_NO = table.Column<string>(nullable: true),
                    CLNDR_ACCTG_MNTH_NO = table.Column<string>(nullable: true),
                    CLNDR_ACCTG_YR_NO = table.Column<string>(nullable: true),
                    LOB_CD = table.Column<string>(nullable: true),
                    DBT_CR_IND = table.Column<string>(nullable: true),
                    CONVERTED_AMT = table.Column<string>(nullable: true),
                    BCTR_CD = table.Column<string>(nullable: true),
                    REINS_CMPNY_CD = table.Column<string>(nullable: true),
                    STATE_CD = table.Column<string>(nullable: true),
                    TAX_STAT_TXT = table.Column<string>(nullable: true),
                    HDR_DESC_TXT = table.Column<string>(nullable: true),
                    PLAN_CD = table.Column<string>(nullable: true),
                    SAP_ACCT_NO = table.Column<string>(nullable: true),
                    PRFT_CTR_TXT = table.Column<string>(nullable: true),
                    PLCY_NO = table.Column<string>(nullable: true),
                    TRANS_DT = table.Column<string>(nullable: true),
                    CLNDR_DT = table.Column<string>(nullable: true),
                    MEMO_CD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gpds", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gpds");
        }
    }
}
