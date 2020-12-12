// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// <auto-generated />

namespace EFMultiTenantElasticScale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddTenantId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "TenantId", c => c.Int(nullable: false));
            AddColumn("dbo.Posts", "TenantId", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Posts", "TenantId");
            DropColumn("dbo.Blogs", "TenantId");
        }
    }
}
