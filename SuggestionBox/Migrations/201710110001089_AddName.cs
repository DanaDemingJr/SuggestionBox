namespace SuggestionBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SuggestionModels", "Name", c => c.String());
            AddColumn("dbo.SuggestionModels", "Address", c => c.String());
            DropColumn("dbo.SuggestionModels", "Topic");
            DropColumn("dbo.SuggestionModels", "Suggestion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SuggestionModels", "Suggestion", c => c.String());
            AddColumn("dbo.SuggestionModels", "Topic", c => c.String());
            DropColumn("dbo.SuggestionModels", "Address");
            DropColumn("dbo.SuggestionModels", "Name");
        }
    }
}
