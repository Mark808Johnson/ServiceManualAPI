using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EtteplanMORE.ServiceManual.Infrastructure.Migrations
{
    public partial class AddedSeedDataToFactoryDeviceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 1, "Device 0", "Type 19", 2004 },
                    { 2, "Device 1", "Type 2", 1987 },
                    { 3, "Device 2", "Type 11", 1982 },
                    { 4, "Device 3", "Type 5", 1995 },
                    { 5, "Device 4", "Type 8", 1995 },
                    { 6, "Device 5", "Type 15", 2002 },
                    { 7, "Device 6", "Type 18", 1996 },
                    { 8, "Device 7", "Type 13", 1981 },
                    { 9, "Device 8", "Type 10", 2006 },
                    { 10, "Device 9", "Type 18", 1990 },
                    { 11, "Device 10", "Type 15", 2005 },
                    { 12, "Device 11", "Type 10", 2003 },
                    { 13, "Device 12", "Type 7", 2002 },
                    { 14, "Device 13", "Type 14", 2001 },
                    { 15, "Device 14", "Type 8", 1991 },
                    { 16, "Device 15", "Type 7", 1980 },
                    { 17, "Device 16", "Type 8", 2018 },
                    { 18, "Device 17", "Type 8", 1987 },
                    { 19, "Device 18", "Type 18", 1981 },
                    { 20, "Device 19", "Type 17", 2018 },
                    { 21, "Device 20", "Type 17", 1990 },
                    { 22, "Device 21", "Type 6", 2008 },
                    { 23, "Device 22", "Type 18", 2011 },
                    { 24, "Device 23", "Type 3", 1983 },
                    { 25, "Device 24", "Type 7", 2016 },
                    { 26, "Device 25", "Type 5", 2014 },
                    { 27, "Device 26", "Type 17", 1988 },
                    { 28, "Device 27", "Type 6", 1992 },
                    { 29, "Device 28", "Type 2", 1998 },
                    { 30, "Device 29", "Type 19", 1985 },
                    { 31, "Device 30", "Type 11", 1996 },
                    { 32, "Device 31", "Type 9", 1986 },
                    { 33, "Device 32", "Type 10", 2005 },
                    { 34, "Device 33", "Type 19", 1984 },
                    { 35, "Device 34", "Type 7", 2015 },
                    { 36, "Device 35", "Type 3", 2016 },
                    { 37, "Device 36", "Type 14", 2011 },
                    { 38, "Device 37", "Type 7", 2009 },
                    { 39, "Device 38", "Type 6", 1982 },
                    { 40, "Device 39", "Type 18", 2008 },
                    { 41, "Device 40", "Type 5", 1993 },
                    { 42, "Device 41", "Type 3", 1984 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 43, "Device 42", "Type 9", 2007 },
                    { 44, "Device 43", "Type 14", 2018 },
                    { 45, "Device 44", "Type 2", 2001 },
                    { 46, "Device 45", "Type 18", 1993 },
                    { 47, "Device 46", "Type 11", 1998 },
                    { 48, "Device 47", "Type 14", 2012 },
                    { 49, "Device 48", "Type 10", 1987 },
                    { 50, "Device 49", "Type 4", 2006 },
                    { 51, "Device 50", "Type 15", 2006 },
                    { 52, "Device 51", "Type 2", 1988 },
                    { 53, "Device 52", "Type 12", 2011 },
                    { 54, "Device 53", "Type 4", 1996 },
                    { 55, "Device 54", "Type 17", 2016 },
                    { 56, "Device 55", "Type 18", 2007 },
                    { 57, "Device 56", "Type 5", 2016 },
                    { 58, "Device 57", "Type 12", 2010 },
                    { 59, "Device 58", "Type 4", 2015 },
                    { 60, "Device 59", "Type 14", 1989 },
                    { 61, "Device 60", "Type 14", 1983 },
                    { 62, "Device 61", "Type 4", 1993 },
                    { 63, "Device 62", "Type 18", 2010 },
                    { 64, "Device 63", "Type 11", 1983 },
                    { 65, "Device 64", "Type 7", 1996 },
                    { 66, "Device 65", "Type 14", 1989 },
                    { 67, "Device 66", "Type 18", 2005 },
                    { 68, "Device 67", "Type 16", 1984 },
                    { 69, "Device 68", "Type 1", 1987 },
                    { 70, "Device 69", "Type 16", 1981 },
                    { 71, "Device 70", "Type 16", 2014 },
                    { 72, "Device 71", "Type 4", 2004 },
                    { 73, "Device 72", "Type 19", 2008 },
                    { 74, "Device 73", "Type 17", 1986 },
                    { 75, "Device 74", "Type 19", 2001 },
                    { 76, "Device 75", "Type 13", 2006 },
                    { 77, "Device 76", "Type 6", 1996 },
                    { 78, "Device 77", "Type 17", 1995 },
                    { 79, "Device 78", "Type 1", 2000 },
                    { 80, "Device 79", "Type 15", 2004 },
                    { 81, "Device 80", "Type 1", 1980 },
                    { 82, "Device 81", "Type 14", 2015 },
                    { 83, "Device 82", "Type 19", 1980 },
                    { 84, "Device 83", "Type 16", 1991 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 85, "Device 84", "Type 9", 1994 },
                    { 86, "Device 85", "Type 3", 1996 },
                    { 87, "Device 86", "Type 3", 1996 },
                    { 88, "Device 87", "Type 7", 1997 },
                    { 89, "Device 88", "Type 17", 1980 },
                    { 90, "Device 89", "Type 4", 1984 },
                    { 91, "Device 90", "Type 8", 1989 },
                    { 92, "Device 91", "Type 2", 1984 },
                    { 93, "Device 92", "Type 19", 2007 },
                    { 94, "Device 93", "Type 13", 2007 },
                    { 95, "Device 94", "Type 2", 1987 },
                    { 96, "Device 95", "Type 9", 1980 },
                    { 97, "Device 96", "Type 18", 1988 },
                    { 98, "Device 97", "Type 10", 1996 },
                    { 99, "Device 98", "Type 8", 1999 },
                    { 100, "Device 99", "Type 12", 2016 },
                    { 101, "Device 100", "Type 4", 1992 },
                    { 102, "Device 101", "Type 15", 1982 },
                    { 103, "Device 102", "Type 2", 2010 },
                    { 104, "Device 103", "Type 12", 1996 },
                    { 105, "Device 104", "Type 6", 1984 },
                    { 106, "Device 105", "Type 12", 2013 },
                    { 107, "Device 106", "Type 8", 2004 },
                    { 108, "Device 107", "Type 4", 2013 },
                    { 109, "Device 108", "Type 6", 2007 },
                    { 110, "Device 109", "Type 7", 2012 },
                    { 111, "Device 110", "Type 18", 2013 },
                    { 112, "Device 111", "Type 3", 1983 },
                    { 113, "Device 112", "Type 1", 1996 },
                    { 114, "Device 113", "Type 8", 2017 },
                    { 115, "Device 114", "Type 10", 1988 },
                    { 116, "Device 115", "Type 9", 2017 },
                    { 117, "Device 116", "Type 15", 1989 },
                    { 118, "Device 117", "Type 14", 2010 },
                    { 119, "Device 118", "Type 4", 1985 },
                    { 120, "Device 119", "Type 18", 1980 },
                    { 121, "Device 120", "Type 6", 1983 },
                    { 122, "Device 121", "Type 11", 2004 },
                    { 123, "Device 122", "Type 8", 1993 },
                    { 124, "Device 123", "Type 14", 1989 },
                    { 125, "Device 124", "Type 17", 1987 },
                    { 126, "Device 125", "Type 6", 2015 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 127, "Device 126", "Type 3", 2009 },
                    { 128, "Device 127", "Type 4", 2009 },
                    { 129, "Device 128", "Type 19", 2002 },
                    { 130, "Device 129", "Type 2", 1994 },
                    { 131, "Device 130", "Type 4", 2011 },
                    { 132, "Device 131", "Type 3", 1992 },
                    { 133, "Device 132", "Type 13", 1996 },
                    { 134, "Device 133", "Type 17", 1999 },
                    { 135, "Device 134", "Type 4", 2008 },
                    { 136, "Device 135", "Type 13", 2013 },
                    { 137, "Device 136", "Type 2", 2005 },
                    { 138, "Device 137", "Type 10", 1999 },
                    { 139, "Device 138", "Type 8", 1996 },
                    { 140, "Device 139", "Type 12", 1983 },
                    { 141, "Device 140", "Type 18", 1993 },
                    { 142, "Device 141", "Type 13", 2009 },
                    { 143, "Device 142", "Type 11", 1988 },
                    { 144, "Device 143", "Type 3", 2018 },
                    { 145, "Device 144", "Type 18", 2017 },
                    { 146, "Device 145", "Type 16", 1994 },
                    { 147, "Device 146", "Type 16", 2018 },
                    { 148, "Device 147", "Type 9", 1984 },
                    { 149, "Device 148", "Type 7", 1981 },
                    { 150, "Device 149", "Type 15", 1984 },
                    { 151, "Device 150", "Type 5", 2010 },
                    { 152, "Device 151", "Type 19", 1995 },
                    { 153, "Device 152", "Type 2", 2009 },
                    { 154, "Device 153", "Type 2", 2002 },
                    { 155, "Device 154", "Type 2", 2016 },
                    { 156, "Device 155", "Type 18", 2013 },
                    { 157, "Device 156", "Type 4", 2002 },
                    { 158, "Device 157", "Type 2", 1986 },
                    { 159, "Device 158", "Type 7", 1984 },
                    { 160, "Device 159", "Type 3", 2009 },
                    { 161, "Device 160", "Type 19", 1986 },
                    { 162, "Device 161", "Type 1", 2010 },
                    { 163, "Device 162", "Type 6", 1990 },
                    { 164, "Device 163", "Type 8", 1997 },
                    { 165, "Device 164", "Type 8", 1999 },
                    { 166, "Device 165", "Type 2", 1992 },
                    { 167, "Device 166", "Type 19", 2003 },
                    { 168, "Device 167", "Type 10", 1980 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 169, "Device 168", "Type 15", 2015 },
                    { 170, "Device 169", "Type 19", 2010 },
                    { 171, "Device 170", "Type 17", 1984 },
                    { 172, "Device 171", "Type 9", 2004 },
                    { 173, "Device 172", "Type 6", 2005 },
                    { 174, "Device 173", "Type 4", 2001 },
                    { 175, "Device 174", "Type 9", 1983 },
                    { 176, "Device 175", "Type 4", 1998 },
                    { 177, "Device 176", "Type 6", 2017 },
                    { 178, "Device 177", "Type 1", 2013 },
                    { 179, "Device 178", "Type 2", 2018 },
                    { 180, "Device 179", "Type 3", 2016 },
                    { 181, "Device 180", "Type 11", 2002 },
                    { 182, "Device 181", "Type 19", 1993 },
                    { 183, "Device 182", "Type 4", 1996 },
                    { 184, "Device 183", "Type 18", 1987 },
                    { 185, "Device 184", "Type 6", 1992 },
                    { 186, "Device 185", "Type 11", 1989 },
                    { 187, "Device 186", "Type 8", 1987 },
                    { 188, "Device 187", "Type 3", 2013 },
                    { 189, "Device 188", "Type 16", 1986 },
                    { 190, "Device 189", "Type 11", 2016 },
                    { 191, "Device 190", "Type 7", 1986 },
                    { 192, "Device 191", "Type 18", 1984 },
                    { 193, "Device 192", "Type 12", 1997 },
                    { 194, "Device 193", "Type 17", 2009 },
                    { 195, "Device 194", "Type 10", 2010 },
                    { 196, "Device 195", "Type 12", 1999 },
                    { 197, "Device 196", "Type 16", 1985 },
                    { 198, "Device 197", "Type 19", 1986 },
                    { 199, "Device 198", "Type 3", 2007 },
                    { 200, "Device 199", "Type 18", 1989 },
                    { 201, "Device 200", "Type 13", 1997 },
                    { 202, "Device 201", "Type 10", 2015 },
                    { 203, "Device 202", "Type 15", 2015 },
                    { 204, "Device 203", "Type 2", 1981 },
                    { 205, "Device 204", "Type 19", 1984 },
                    { 206, "Device 205", "Type 5", 1990 },
                    { 207, "Device 206", "Type 5", 2000 },
                    { 208, "Device 207", "Type 7", 1995 },
                    { 209, "Device 208", "Type 19", 1993 },
                    { 210, "Device 209", "Type 14", 1991 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 211, "Device 210", "Type 13", 1995 },
                    { 212, "Device 211", "Type 5", 2015 },
                    { 213, "Device 212", "Type 11", 1993 },
                    { 214, "Device 213", "Type 8", 1991 },
                    { 215, "Device 214", "Type 10", 2005 },
                    { 216, "Device 215", "Type 3", 2014 },
                    { 217, "Device 216", "Type 14", 1995 },
                    { 218, "Device 217", "Type 6", 2015 },
                    { 219, "Device 218", "Type 14", 1987 },
                    { 220, "Device 219", "Type 7", 1982 },
                    { 221, "Device 220", "Type 1", 1982 },
                    { 222, "Device 221", "Type 11", 2006 },
                    { 223, "Device 222", "Type 16", 2014 },
                    { 224, "Device 223", "Type 17", 2005 },
                    { 225, "Device 224", "Type 5", 1985 },
                    { 226, "Device 225", "Type 5", 2002 },
                    { 227, "Device 226", "Type 13", 1980 },
                    { 228, "Device 227", "Type 1", 2014 },
                    { 229, "Device 228", "Type 4", 1984 },
                    { 230, "Device 229", "Type 10", 2007 },
                    { 231, "Device 230", "Type 11", 1991 },
                    { 232, "Device 231", "Type 3", 2008 },
                    { 233, "Device 232", "Type 16", 2016 },
                    { 234, "Device 233", "Type 8", 1988 },
                    { 235, "Device 234", "Type 19", 1995 },
                    { 236, "Device 235", "Type 10", 1997 },
                    { 237, "Device 236", "Type 5", 2010 },
                    { 238, "Device 237", "Type 5", 2005 },
                    { 239, "Device 238", "Type 19", 2011 },
                    { 240, "Device 239", "Type 3", 1986 },
                    { 241, "Device 240", "Type 7", 1986 },
                    { 242, "Device 241", "Type 1", 1980 },
                    { 243, "Device 242", "Type 4", 2004 },
                    { 244, "Device 243", "Type 9", 1981 },
                    { 245, "Device 244", "Type 18", 2004 },
                    { 246, "Device 245", "Type 4", 1996 },
                    { 247, "Device 246", "Type 18", 1980 },
                    { 248, "Device 247", "Type 11", 2010 },
                    { 249, "Device 248", "Type 18", 1998 },
                    { 250, "Device 249", "Type 14", 1990 },
                    { 251, "Device 250", "Type 5", 1999 },
                    { 252, "Device 251", "Type 14", 2018 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 253, "Device 252", "Type 14", 2008 },
                    { 254, "Device 253", "Type 7", 2014 },
                    { 255, "Device 254", "Type 17", 2009 },
                    { 256, "Device 255", "Type 12", 2017 },
                    { 257, "Device 256", "Type 19", 1981 },
                    { 258, "Device 257", "Type 6", 1994 },
                    { 259, "Device 258", "Type 16", 2004 },
                    { 260, "Device 259", "Type 17", 1995 },
                    { 261, "Device 260", "Type 8", 2017 },
                    { 262, "Device 261", "Type 10", 2014 },
                    { 263, "Device 262", "Type 7", 1982 },
                    { 264, "Device 263", "Type 9", 1985 },
                    { 265, "Device 264", "Type 12", 2014 },
                    { 266, "Device 265", "Type 16", 1988 },
                    { 267, "Device 266", "Type 1", 2016 },
                    { 268, "Device 267", "Type 10", 2011 },
                    { 269, "Device 268", "Type 3", 1986 },
                    { 270, "Device 269", "Type 18", 1998 },
                    { 271, "Device 270", "Type 8", 1984 },
                    { 272, "Device 271", "Type 18", 2003 },
                    { 273, "Device 272", "Type 5", 1986 },
                    { 274, "Device 273", "Type 2", 2000 },
                    { 275, "Device 274", "Type 10", 1998 },
                    { 276, "Device 275", "Type 15", 2001 },
                    { 277, "Device 276", "Type 19", 1983 },
                    { 278, "Device 277", "Type 11", 1999 },
                    { 279, "Device 278", "Type 5", 1992 },
                    { 280, "Device 279", "Type 14", 2006 },
                    { 281, "Device 280", "Type 4", 2001 },
                    { 282, "Device 281", "Type 11", 2010 },
                    { 283, "Device 282", "Type 17", 1981 },
                    { 284, "Device 283", "Type 3", 2003 },
                    { 285, "Device 284", "Type 18", 2004 },
                    { 286, "Device 285", "Type 19", 1997 },
                    { 287, "Device 286", "Type 5", 1985 },
                    { 288, "Device 287", "Type 10", 2011 },
                    { 289, "Device 288", "Type 10", 1980 },
                    { 290, "Device 289", "Type 16", 2018 },
                    { 291, "Device 290", "Type 2", 2004 },
                    { 292, "Device 291", "Type 6", 2014 },
                    { 293, "Device 292", "Type 13", 2008 },
                    { 294, "Device 293", "Type 6", 2008 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 295, "Device 294", "Type 6", 2001 },
                    { 296, "Device 295", "Type 13", 2007 },
                    { 297, "Device 296", "Type 10", 2005 },
                    { 298, "Device 297", "Type 3", 1982 },
                    { 299, "Device 298", "Type 4", 2011 },
                    { 300, "Device 299", "Type 18", 1989 },
                    { 301, "Device 300", "Type 4", 2018 },
                    { 302, "Device 301", "Type 12", 2015 },
                    { 303, "Device 302", "Type 6", 1988 },
                    { 304, "Device 303", "Type 15", 1997 },
                    { 305, "Device 304", "Type 7", 1981 },
                    { 306, "Device 305", "Type 6", 2002 },
                    { 307, "Device 306", "Type 14", 2017 },
                    { 308, "Device 307", "Type 12", 2004 },
                    { 309, "Device 308", "Type 6", 1992 },
                    { 310, "Device 309", "Type 6", 2005 },
                    { 311, "Device 310", "Type 1", 2006 },
                    { 312, "Device 311", "Type 13", 2012 },
                    { 313, "Device 312", "Type 19", 1991 },
                    { 314, "Device 313", "Type 12", 1987 },
                    { 315, "Device 314", "Type 12", 1997 },
                    { 316, "Device 315", "Type 11", 1997 },
                    { 317, "Device 316", "Type 8", 1990 },
                    { 318, "Device 317", "Type 2", 1985 },
                    { 319, "Device 318", "Type 17", 1994 },
                    { 320, "Device 319", "Type 16", 2006 },
                    { 321, "Device 320", "Type 13", 1990 },
                    { 322, "Device 321", "Type 17", 2014 },
                    { 323, "Device 322", "Type 3", 1992 },
                    { 324, "Device 323", "Type 1", 1996 },
                    { 325, "Device 324", "Type 6", 1996 },
                    { 326, "Device 325", "Type 6", 2005 },
                    { 327, "Device 326", "Type 5", 1995 },
                    { 328, "Device 327", "Type 13", 2011 },
                    { 329, "Device 328", "Type 13", 1997 },
                    { 330, "Device 329", "Type 11", 1998 },
                    { 331, "Device 330", "Type 6", 1986 },
                    { 332, "Device 331", "Type 12", 2011 },
                    { 333, "Device 332", "Type 17", 2008 },
                    { 334, "Device 333", "Type 19", 2013 },
                    { 335, "Device 334", "Type 11", 1981 },
                    { 336, "Device 335", "Type 16", 2003 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 337, "Device 336", "Type 11", 1994 },
                    { 338, "Device 337", "Type 9", 1996 },
                    { 339, "Device 338", "Type 13", 2016 },
                    { 340, "Device 339", "Type 18", 2011 },
                    { 341, "Device 340", "Type 9", 2012 },
                    { 342, "Device 341", "Type 2", 2008 },
                    { 343, "Device 342", "Type 12", 2003 },
                    { 344, "Device 343", "Type 16", 2012 },
                    { 345, "Device 344", "Type 11", 1981 },
                    { 346, "Device 345", "Type 15", 1982 },
                    { 347, "Device 346", "Type 18", 1981 },
                    { 348, "Device 347", "Type 18", 1990 },
                    { 349, "Device 348", "Type 14", 2015 },
                    { 350, "Device 349", "Type 17", 2016 },
                    { 351, "Device 350", "Type 12", 1991 },
                    { 352, "Device 351", "Type 11", 1994 },
                    { 353, "Device 352", "Type 18", 2018 },
                    { 354, "Device 353", "Type 3", 1994 },
                    { 355, "Device 354", "Type 18", 1995 },
                    { 356, "Device 355", "Type 1", 2001 },
                    { 357, "Device 356", "Type 19", 1993 },
                    { 358, "Device 357", "Type 15", 1998 },
                    { 359, "Device 358", "Type 5", 1993 },
                    { 360, "Device 359", "Type 14", 1993 },
                    { 361, "Device 360", "Type 2", 1988 },
                    { 362, "Device 361", "Type 16", 1998 },
                    { 363, "Device 362", "Type 1", 2010 },
                    { 364, "Device 363", "Type 9", 1980 },
                    { 365, "Device 364", "Type 14", 2002 },
                    { 366, "Device 365", "Type 16", 2010 },
                    { 367, "Device 366", "Type 4", 1997 },
                    { 368, "Device 367", "Type 5", 1992 },
                    { 369, "Device 368", "Type 1", 2009 },
                    { 370, "Device 369", "Type 3", 1981 },
                    { 371, "Device 370", "Type 8", 2005 },
                    { 372, "Device 371", "Type 9", 1992 },
                    { 373, "Device 372", "Type 6", 1995 },
                    { 374, "Device 373", "Type 16", 2000 },
                    { 375, "Device 374", "Type 19", 1998 },
                    { 376, "Device 375", "Type 2", 1994 },
                    { 377, "Device 376", "Type 17", 2000 },
                    { 378, "Device 377", "Type 12", 2012 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 379, "Device 378", "Type 7", 2010 },
                    { 380, "Device 379", "Type 10", 1987 },
                    { 381, "Device 380", "Type 15", 1980 },
                    { 382, "Device 381", "Type 13", 2001 },
                    { 383, "Device 382", "Type 4", 1995 },
                    { 384, "Device 383", "Type 8", 1994 },
                    { 385, "Device 384", "Type 5", 2004 },
                    { 386, "Device 385", "Type 4", 2018 },
                    { 387, "Device 386", "Type 18", 1994 },
                    { 388, "Device 387", "Type 13", 1989 },
                    { 389, "Device 388", "Type 4", 1993 },
                    { 390, "Device 389", "Type 2", 2010 },
                    { 391, "Device 390", "Type 6", 2010 },
                    { 392, "Device 391", "Type 17", 1994 },
                    { 393, "Device 392", "Type 13", 1984 },
                    { 394, "Device 393", "Type 8", 2011 },
                    { 395, "Device 394", "Type 9", 1994 },
                    { 396, "Device 395", "Type 11", 2013 },
                    { 397, "Device 396", "Type 17", 1980 },
                    { 398, "Device 397", "Type 17", 1988 },
                    { 399, "Device 398", "Type 15", 2017 },
                    { 400, "Device 399", "Type 19", 1998 },
                    { 401, "Device 400", "Type 14", 2002 },
                    { 402, "Device 401", "Type 8", 2014 },
                    { 403, "Device 402", "Type 16", 1993 },
                    { 404, "Device 403", "Type 19", 1988 },
                    { 405, "Device 404", "Type 10", 1984 },
                    { 406, "Device 405", "Type 8", 1985 },
                    { 407, "Device 406", "Type 10", 2009 },
                    { 408, "Device 407", "Type 18", 2006 },
                    { 409, "Device 408", "Type 11", 2017 },
                    { 410, "Device 409", "Type 6", 1982 },
                    { 411, "Device 410", "Type 3", 1982 },
                    { 412, "Device 411", "Type 18", 1980 },
                    { 413, "Device 412", "Type 13", 1994 },
                    { 414, "Device 413", "Type 5", 2005 },
                    { 415, "Device 414", "Type 6", 1994 },
                    { 416, "Device 415", "Type 17", 2007 },
                    { 417, "Device 416", "Type 12", 2014 },
                    { 418, "Device 417", "Type 3", 1999 },
                    { 419, "Device 418", "Type 18", 2013 },
                    { 420, "Device 419", "Type 16", 2004 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 421, "Device 420", "Type 4", 2017 },
                    { 422, "Device 421", "Type 9", 2011 },
                    { 423, "Device 422", "Type 2", 2010 },
                    { 424, "Device 423", "Type 3", 2005 },
                    { 425, "Device 424", "Type 15", 2017 },
                    { 426, "Device 425", "Type 13", 1992 },
                    { 427, "Device 426", "Type 3", 2003 },
                    { 428, "Device 427", "Type 3", 2007 },
                    { 429, "Device 428", "Type 16", 1996 },
                    { 430, "Device 429", "Type 2", 1986 },
                    { 431, "Device 430", "Type 2", 1993 },
                    { 432, "Device 431", "Type 18", 2003 },
                    { 433, "Device 432", "Type 19", 2000 },
                    { 434, "Device 433", "Type 8", 2001 },
                    { 435, "Device 434", "Type 13", 2009 },
                    { 436, "Device 435", "Type 15", 1989 },
                    { 437, "Device 436", "Type 17", 2011 },
                    { 438, "Device 437", "Type 19", 1985 },
                    { 439, "Device 438", "Type 7", 1983 },
                    { 440, "Device 439", "Type 2", 2003 },
                    { 441, "Device 440", "Type 8", 2013 },
                    { 442, "Device 441", "Type 3", 1996 },
                    { 443, "Device 442", "Type 16", 1988 },
                    { 444, "Device 443", "Type 19", 2016 },
                    { 445, "Device 444", "Type 12", 1996 },
                    { 446, "Device 445", "Type 8", 1994 },
                    { 447, "Device 446", "Type 3", 1982 },
                    { 448, "Device 447", "Type 13", 1996 },
                    { 449, "Device 448", "Type 3", 1990 },
                    { 450, "Device 449", "Type 16", 1994 },
                    { 451, "Device 450", "Type 15", 1998 },
                    { 452, "Device 451", "Type 18", 1985 },
                    { 453, "Device 452", "Type 2", 1989 },
                    { 454, "Device 453", "Type 3", 1988 },
                    { 455, "Device 454", "Type 12", 2002 },
                    { 456, "Device 455", "Type 10", 2010 },
                    { 457, "Device 456", "Type 7", 1991 },
                    { 458, "Device 457", "Type 10", 2009 },
                    { 459, "Device 458", "Type 12", 1983 },
                    { 460, "Device 459", "Type 3", 1991 },
                    { 461, "Device 460", "Type 7", 2009 },
                    { 462, "Device 461", "Type 5", 1985 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 463, "Device 462", "Type 4", 2011 },
                    { 464, "Device 463", "Type 19", 1983 },
                    { 465, "Device 464", "Type 5", 1980 },
                    { 466, "Device 465", "Type 17", 1993 },
                    { 467, "Device 466", "Type 4", 2001 },
                    { 468, "Device 467", "Type 3", 2002 },
                    { 469, "Device 468", "Type 4", 2013 },
                    { 470, "Device 469", "Type 14", 1980 },
                    { 471, "Device 470", "Type 10", 1996 },
                    { 472, "Device 471", "Type 1", 1996 },
                    { 473, "Device 472", "Type 1", 2008 },
                    { 474, "Device 473", "Type 5", 1989 },
                    { 475, "Device 474", "Type 18", 2016 },
                    { 476, "Device 475", "Type 4", 1985 },
                    { 477, "Device 476", "Type 5", 2014 },
                    { 478, "Device 477", "Type 18", 1999 },
                    { 479, "Device 478", "Type 10", 1984 },
                    { 480, "Device 479", "Type 10", 1989 },
                    { 481, "Device 480", "Type 7", 1999 },
                    { 482, "Device 481", "Type 13", 1999 },
                    { 483, "Device 482", "Type 18", 2017 },
                    { 484, "Device 483", "Type 18", 2008 },
                    { 485, "Device 484", "Type 12", 2006 },
                    { 486, "Device 485", "Type 14", 2006 },
                    { 487, "Device 486", "Type 10", 1982 },
                    { 488, "Device 487", "Type 2", 2001 },
                    { 489, "Device 488", "Type 16", 2017 },
                    { 490, "Device 489", "Type 4", 2014 },
                    { 491, "Device 490", "Type 13", 1993 },
                    { 492, "Device 491", "Type 2", 2006 },
                    { 493, "Device 492", "Type 7", 2010 },
                    { 494, "Device 493", "Type 3", 1993 },
                    { 495, "Device 494", "Type 6", 1998 },
                    { 496, "Device 495", "Type 16", 2013 },
                    { 497, "Device 496", "Type 8", 1985 },
                    { 498, "Device 497", "Type 19", 2014 },
                    { 499, "Device 498", "Type 16", 1982 },
                    { 500, "Device 499", "Type 1", 1984 },
                    { 501, "Device 500", "Type 7", 1995 },
                    { 502, "Device 501", "Type 14", 2004 },
                    { 503, "Device 502", "Type 19", 1992 },
                    { 504, "Device 503", "Type 7", 1982 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 505, "Device 504", "Type 5", 1991 },
                    { 506, "Device 505", "Type 2", 2002 },
                    { 507, "Device 506", "Type 6", 1998 },
                    { 508, "Device 507", "Type 14", 1997 },
                    { 509, "Device 508", "Type 12", 1989 },
                    { 510, "Device 509", "Type 9", 2004 },
                    { 511, "Device 510", "Type 8", 1991 },
                    { 512, "Device 511", "Type 9", 1997 },
                    { 513, "Device 512", "Type 18", 1986 },
                    { 514, "Device 513", "Type 17", 2004 },
                    { 515, "Device 514", "Type 18", 2006 },
                    { 516, "Device 515", "Type 9", 2002 },
                    { 517, "Device 516", "Type 2", 1996 },
                    { 518, "Device 517", "Type 19", 2007 },
                    { 519, "Device 518", "Type 6", 2008 },
                    { 520, "Device 519", "Type 3", 2012 },
                    { 521, "Device 520", "Type 15", 1982 },
                    { 522, "Device 521", "Type 9", 1984 },
                    { 523, "Device 522", "Type 14", 1997 },
                    { 524, "Device 523", "Type 10", 1983 },
                    { 525, "Device 524", "Type 12", 1980 },
                    { 526, "Device 525", "Type 5", 1988 },
                    { 527, "Device 526", "Type 18", 1987 },
                    { 528, "Device 527", "Type 5", 2017 },
                    { 529, "Device 528", "Type 4", 1996 },
                    { 530, "Device 529", "Type 16", 1986 },
                    { 531, "Device 530", "Type 16", 1998 },
                    { 532, "Device 531", "Type 14", 2010 },
                    { 533, "Device 532", "Type 10", 1995 },
                    { 534, "Device 533", "Type 9", 1993 },
                    { 535, "Device 534", "Type 12", 2009 },
                    { 536, "Device 535", "Type 18", 1984 },
                    { 537, "Device 536", "Type 15", 2015 },
                    { 538, "Device 537", "Type 6", 1992 },
                    { 539, "Device 538", "Type 10", 2002 },
                    { 540, "Device 539", "Type 6", 1993 },
                    { 541, "Device 540", "Type 19", 2001 },
                    { 542, "Device 541", "Type 3", 1994 },
                    { 543, "Device 542", "Type 19", 1988 },
                    { 544, "Device 543", "Type 8", 1992 },
                    { 545, "Device 544", "Type 13", 2009 },
                    { 546, "Device 545", "Type 17", 1994 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 547, "Device 546", "Type 3", 2011 },
                    { 548, "Device 547", "Type 2", 1981 },
                    { 549, "Device 548", "Type 8", 2002 },
                    { 550, "Device 549", "Type 7", 2017 },
                    { 551, "Device 550", "Type 3", 1985 },
                    { 552, "Device 551", "Type 13", 2000 },
                    { 553, "Device 552", "Type 1", 1991 },
                    { 554, "Device 553", "Type 7", 2005 },
                    { 555, "Device 554", "Type 13", 1984 },
                    { 556, "Device 555", "Type 8", 2002 },
                    { 557, "Device 556", "Type 7", 2015 },
                    { 558, "Device 557", "Type 14", 2015 },
                    { 559, "Device 558", "Type 13", 2007 },
                    { 560, "Device 559", "Type 10", 2015 },
                    { 561, "Device 560", "Type 1", 1984 },
                    { 562, "Device 561", "Type 12", 1989 },
                    { 563, "Device 562", "Type 4", 1999 },
                    { 564, "Device 563", "Type 18", 2002 },
                    { 565, "Device 564", "Type 14", 2016 },
                    { 566, "Device 565", "Type 8", 2001 },
                    { 567, "Device 566", "Type 8", 1980 },
                    { 568, "Device 567", "Type 17", 2008 },
                    { 569, "Device 568", "Type 9", 2006 },
                    { 570, "Device 569", "Type 17", 2013 },
                    { 571, "Device 570", "Type 19", 1985 },
                    { 572, "Device 571", "Type 5", 2004 },
                    { 573, "Device 572", "Type 14", 2003 },
                    { 574, "Device 573", "Type 5", 1993 },
                    { 575, "Device 574", "Type 5", 1995 },
                    { 576, "Device 575", "Type 18", 2012 },
                    { 577, "Device 576", "Type 19", 2005 },
                    { 578, "Device 577", "Type 2", 1996 },
                    { 579, "Device 578", "Type 9", 1986 },
                    { 580, "Device 579", "Type 11", 2002 },
                    { 581, "Device 580", "Type 10", 2007 },
                    { 582, "Device 581", "Type 7", 1984 },
                    { 583, "Device 582", "Type 11", 2002 },
                    { 584, "Device 583", "Type 4", 2014 },
                    { 585, "Device 584", "Type 5", 2011 },
                    { 586, "Device 585", "Type 11", 1983 },
                    { 587, "Device 586", "Type 18", 1988 },
                    { 588, "Device 587", "Type 6", 1991 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 589, "Device 588", "Type 7", 1993 },
                    { 590, "Device 589", "Type 7", 1992 },
                    { 591, "Device 590", "Type 11", 1996 },
                    { 592, "Device 591", "Type 9", 2004 },
                    { 593, "Device 592", "Type 18", 2002 },
                    { 594, "Device 593", "Type 17", 1980 },
                    { 595, "Device 594", "Type 10", 1999 },
                    { 596, "Device 595", "Type 14", 1991 },
                    { 597, "Device 596", "Type 10", 2003 },
                    { 598, "Device 597", "Type 7", 1991 },
                    { 599, "Device 598", "Type 16", 1985 },
                    { 600, "Device 599", "Type 12", 1985 },
                    { 601, "Device 600", "Type 14", 2015 },
                    { 602, "Device 601", "Type 18", 2000 },
                    { 603, "Device 602", "Type 4", 1998 },
                    { 604, "Device 603", "Type 1", 2012 },
                    { 605, "Device 604", "Type 15", 1999 },
                    { 606, "Device 605", "Type 9", 2011 },
                    { 607, "Device 606", "Type 3", 1986 },
                    { 608, "Device 607", "Type 8", 1990 },
                    { 609, "Device 608", "Type 7", 1987 },
                    { 610, "Device 609", "Type 1", 1983 },
                    { 611, "Device 610", "Type 1", 2016 },
                    { 612, "Device 611", "Type 3", 1980 },
                    { 613, "Device 612", "Type 8", 1997 },
                    { 614, "Device 613", "Type 19", 2008 },
                    { 615, "Device 614", "Type 7", 1992 },
                    { 616, "Device 615", "Type 14", 1994 },
                    { 617, "Device 616", "Type 13", 2018 },
                    { 618, "Device 617", "Type 11", 1980 },
                    { 619, "Device 618", "Type 3", 1988 },
                    { 620, "Device 619", "Type 7", 2013 },
                    { 621, "Device 620", "Type 3", 1996 },
                    { 622, "Device 621", "Type 11", 2015 },
                    { 623, "Device 622", "Type 14", 2010 },
                    { 624, "Device 623", "Type 18", 2007 },
                    { 625, "Device 624", "Type 4", 1985 },
                    { 626, "Device 625", "Type 4", 1989 },
                    { 627, "Device 626", "Type 19", 1998 },
                    { 628, "Device 627", "Type 2", 1983 },
                    { 629, "Device 628", "Type 14", 2002 },
                    { 630, "Device 629", "Type 1", 1989 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 631, "Device 630", "Type 12", 1996 },
                    { 632, "Device 631", "Type 17", 1996 },
                    { 633, "Device 632", "Type 3", 1987 },
                    { 634, "Device 633", "Type 8", 2007 },
                    { 635, "Device 634", "Type 7", 2014 },
                    { 636, "Device 635", "Type 6", 1998 },
                    { 637, "Device 636", "Type 2", 1999 },
                    { 638, "Device 637", "Type 3", 1988 },
                    { 639, "Device 638", "Type 13", 2001 },
                    { 640, "Device 639", "Type 17", 2014 },
                    { 641, "Device 640", "Type 2", 2008 },
                    { 642, "Device 641", "Type 1", 2017 },
                    { 643, "Device 642", "Type 12", 2005 },
                    { 644, "Device 643", "Type 15", 1992 },
                    { 645, "Device 644", "Type 2", 1993 },
                    { 646, "Device 645", "Type 12", 1998 },
                    { 647, "Device 646", "Type 9", 1989 },
                    { 648, "Device 647", "Type 7", 1991 },
                    { 649, "Device 648", "Type 10", 2005 },
                    { 650, "Device 649", "Type 8", 1987 },
                    { 651, "Device 650", "Type 14", 2017 },
                    { 652, "Device 651", "Type 15", 2007 },
                    { 653, "Device 652", "Type 13", 1988 },
                    { 654, "Device 653", "Type 12", 1998 },
                    { 655, "Device 654", "Type 13", 1995 },
                    { 656, "Device 655", "Type 11", 1992 },
                    { 657, "Device 656", "Type 3", 1989 },
                    { 658, "Device 657", "Type 7", 2001 },
                    { 659, "Device 658", "Type 2", 2007 },
                    { 660, "Device 659", "Type 16", 1983 },
                    { 661, "Device 660", "Type 16", 1988 },
                    { 662, "Device 661", "Type 16", 1995 },
                    { 663, "Device 662", "Type 3", 1996 },
                    { 664, "Device 663", "Type 19", 2018 },
                    { 665, "Device 664", "Type 18", 1981 },
                    { 666, "Device 665", "Type 1", 1991 },
                    { 667, "Device 666", "Type 18", 1987 },
                    { 668, "Device 667", "Type 16", 2009 },
                    { 669, "Device 668", "Type 3", 2009 },
                    { 670, "Device 669", "Type 16", 2012 },
                    { 671, "Device 670", "Type 13", 1998 },
                    { 672, "Device 671", "Type 12", 1995 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 673, "Device 672", "Type 13", 2011 },
                    { 674, "Device 673", "Type 13", 2012 },
                    { 675, "Device 674", "Type 8", 2000 },
                    { 676, "Device 675", "Type 2", 2018 },
                    { 677, "Device 676", "Type 11", 2018 },
                    { 678, "Device 677", "Type 3", 1994 },
                    { 679, "Device 678", "Type 3", 2006 },
                    { 680, "Device 679", "Type 7", 2008 },
                    { 681, "Device 680", "Type 16", 2010 },
                    { 682, "Device 681", "Type 13", 1990 },
                    { 683, "Device 682", "Type 12", 1997 },
                    { 684, "Device 683", "Type 10", 1992 },
                    { 685, "Device 684", "Type 3", 1996 },
                    { 686, "Device 685", "Type 4", 1983 },
                    { 687, "Device 686", "Type 11", 2005 },
                    { 688, "Device 687", "Type 16", 2013 },
                    { 689, "Device 688", "Type 14", 2013 },
                    { 690, "Device 689", "Type 6", 2001 },
                    { 691, "Device 690", "Type 13", 1991 },
                    { 692, "Device 691", "Type 5", 2016 },
                    { 693, "Device 692", "Type 2", 2009 },
                    { 694, "Device 693", "Type 17", 2000 },
                    { 695, "Device 694", "Type 2", 2000 },
                    { 696, "Device 695", "Type 4", 1989 },
                    { 697, "Device 696", "Type 3", 1988 },
                    { 698, "Device 697", "Type 7", 2015 },
                    { 699, "Device 698", "Type 9", 2008 },
                    { 700, "Device 699", "Type 11", 2004 },
                    { 701, "Device 700", "Type 17", 2017 },
                    { 702, "Device 701", "Type 6", 1986 },
                    { 703, "Device 702", "Type 16", 2011 },
                    { 704, "Device 703", "Type 9", 2005 },
                    { 705, "Device 704", "Type 10", 1983 },
                    { 706, "Device 705", "Type 9", 1983 },
                    { 707, "Device 706", "Type 5", 2002 },
                    { 708, "Device 707", "Type 14", 1985 },
                    { 709, "Device 708", "Type 14", 1992 },
                    { 710, "Device 709", "Type 10", 2004 },
                    { 711, "Device 710", "Type 1", 1990 },
                    { 712, "Device 711", "Type 10", 1985 },
                    { 713, "Device 712", "Type 7", 1990 },
                    { 714, "Device 713", "Type 4", 2012 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 715, "Device 714", "Type 13", 1987 },
                    { 716, "Device 715", "Type 12", 2007 },
                    { 717, "Device 716", "Type 9", 2006 },
                    { 718, "Device 717", "Type 18", 1998 },
                    { 719, "Device 718", "Type 16", 1988 },
                    { 720, "Device 719", "Type 10", 1980 },
                    { 721, "Device 720", "Type 14", 2011 },
                    { 722, "Device 721", "Type 16", 1988 },
                    { 723, "Device 722", "Type 2", 1999 },
                    { 724, "Device 723", "Type 5", 2009 },
                    { 725, "Device 724", "Type 13", 2008 },
                    { 726, "Device 725", "Type 10", 1994 },
                    { 727, "Device 726", "Type 10", 2008 },
                    { 728, "Device 727", "Type 2", 1987 },
                    { 729, "Device 728", "Type 3", 1994 },
                    { 730, "Device 729", "Type 2", 1983 },
                    { 731, "Device 730", "Type 7", 1997 },
                    { 732, "Device 731", "Type 12", 2009 },
                    { 733, "Device 732", "Type 17", 2004 },
                    { 734, "Device 733", "Type 11", 2014 },
                    { 735, "Device 734", "Type 19", 1980 },
                    { 736, "Device 735", "Type 12", 2004 },
                    { 737, "Device 736", "Type 19", 1988 },
                    { 738, "Device 737", "Type 9", 2002 },
                    { 739, "Device 738", "Type 10", 1993 },
                    { 740, "Device 739", "Type 9", 1998 },
                    { 741, "Device 740", "Type 15", 1995 },
                    { 742, "Device 741", "Type 9", 2015 },
                    { 743, "Device 742", "Type 3", 1997 },
                    { 744, "Device 743", "Type 13", 1992 },
                    { 745, "Device 744", "Type 8", 2002 },
                    { 746, "Device 745", "Type 4", 1998 },
                    { 747, "Device 746", "Type 16", 1980 },
                    { 748, "Device 747", "Type 11", 1986 },
                    { 749, "Device 748", "Type 4", 1990 },
                    { 750, "Device 749", "Type 9", 2017 },
                    { 751, "Device 750", "Type 19", 1996 },
                    { 752, "Device 751", "Type 5", 2012 },
                    { 753, "Device 752", "Type 9", 2003 },
                    { 754, "Device 753", "Type 9", 2009 },
                    { 755, "Device 754", "Type 19", 2014 },
                    { 756, "Device 755", "Type 13", 1987 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 757, "Device 756", "Type 11", 1999 },
                    { 758, "Device 757", "Type 1", 2010 },
                    { 759, "Device 758", "Type 19", 2008 },
                    { 760, "Device 759", "Type 3", 2015 },
                    { 761, "Device 760", "Type 14", 1985 },
                    { 762, "Device 761", "Type 10", 1992 },
                    { 763, "Device 762", "Type 2", 1984 },
                    { 764, "Device 763", "Type 9", 2010 },
                    { 765, "Device 764", "Type 16", 1990 },
                    { 766, "Device 765", "Type 4", 1993 },
                    { 767, "Device 766", "Type 7", 1995 },
                    { 768, "Device 767", "Type 4", 1988 },
                    { 769, "Device 768", "Type 16", 2015 },
                    { 770, "Device 769", "Type 18", 1996 },
                    { 771, "Device 770", "Type 2", 2002 },
                    { 772, "Device 771", "Type 8", 2013 },
                    { 773, "Device 772", "Type 11", 2008 },
                    { 774, "Device 773", "Type 13", 2002 },
                    { 775, "Device 774", "Type 4", 2002 },
                    { 776, "Device 775", "Type 15", 1995 },
                    { 777, "Device 776", "Type 5", 1982 },
                    { 778, "Device 777", "Type 8", 1998 },
                    { 779, "Device 778", "Type 13", 1983 },
                    { 780, "Device 779", "Type 3", 1996 },
                    { 781, "Device 780", "Type 7", 2017 },
                    { 782, "Device 781", "Type 18", 2000 },
                    { 783, "Device 782", "Type 16", 1981 },
                    { 784, "Device 783", "Type 10", 1995 },
                    { 785, "Device 784", "Type 6", 2018 },
                    { 786, "Device 785", "Type 12", 1987 },
                    { 787, "Device 786", "Type 19", 2002 },
                    { 788, "Device 787", "Type 5", 1997 },
                    { 789, "Device 788", "Type 9", 1985 },
                    { 790, "Device 789", "Type 9", 2010 },
                    { 791, "Device 790", "Type 3", 2003 },
                    { 792, "Device 791", "Type 5", 2010 },
                    { 793, "Device 792", "Type 12", 1994 },
                    { 794, "Device 793", "Type 2", 2003 },
                    { 795, "Device 794", "Type 12", 2014 },
                    { 796, "Device 795", "Type 12", 1992 },
                    { 797, "Device 796", "Type 3", 1980 },
                    { 798, "Device 797", "Type 18", 2011 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 799, "Device 798", "Type 16", 1999 },
                    { 800, "Device 799", "Type 17", 2014 },
                    { 801, "Device 800", "Type 9", 1983 },
                    { 802, "Device 801", "Type 9", 2015 },
                    { 803, "Device 802", "Type 6", 1993 },
                    { 804, "Device 803", "Type 10", 1985 },
                    { 805, "Device 804", "Type 18", 1999 },
                    { 806, "Device 805", "Type 16", 2013 },
                    { 807, "Device 806", "Type 2", 2010 },
                    { 808, "Device 807", "Type 13", 2003 },
                    { 809, "Device 808", "Type 9", 2000 },
                    { 810, "Device 809", "Type 4", 2009 },
                    { 811, "Device 810", "Type 8", 2003 },
                    { 812, "Device 811", "Type 13", 1981 },
                    { 813, "Device 812", "Type 8", 2003 },
                    { 814, "Device 813", "Type 10", 1985 },
                    { 815, "Device 814", "Type 8", 1994 },
                    { 816, "Device 815", "Type 10", 2006 },
                    { 817, "Device 816", "Type 2", 1983 },
                    { 818, "Device 817", "Type 6", 2006 },
                    { 819, "Device 818", "Type 11", 2001 },
                    { 820, "Device 819", "Type 19", 2006 },
                    { 821, "Device 820", "Type 15", 2003 },
                    { 822, "Device 821", "Type 1", 1982 },
                    { 823, "Device 822", "Type 12", 1995 },
                    { 824, "Device 823", "Type 13", 2005 },
                    { 825, "Device 824", "Type 2", 2007 },
                    { 826, "Device 825", "Type 10", 2002 },
                    { 827, "Device 826", "Type 19", 2014 },
                    { 828, "Device 827", "Type 3", 1980 },
                    { 829, "Device 828", "Type 1", 1985 },
                    { 830, "Device 829", "Type 18", 2010 },
                    { 831, "Device 830", "Type 15", 1988 },
                    { 832, "Device 831", "Type 12", 1994 },
                    { 833, "Device 832", "Type 6", 2008 },
                    { 834, "Device 833", "Type 12", 2000 },
                    { 835, "Device 834", "Type 7", 1980 },
                    { 836, "Device 835", "Type 1", 2002 },
                    { 837, "Device 836", "Type 13", 2018 },
                    { 838, "Device 837", "Type 17", 1988 },
                    { 839, "Device 838", "Type 1", 2016 },
                    { 840, "Device 839", "Type 5", 1982 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 841, "Device 840", "Type 5", 2000 },
                    { 842, "Device 841", "Type 17", 2001 },
                    { 843, "Device 842", "Type 17", 2016 },
                    { 844, "Device 843", "Type 13", 2004 },
                    { 845, "Device 844", "Type 2", 1986 },
                    { 846, "Device 845", "Type 16", 2012 },
                    { 847, "Device 846", "Type 17", 2006 },
                    { 848, "Device 847", "Type 16", 1991 },
                    { 849, "Device 848", "Type 19", 2003 },
                    { 850, "Device 849", "Type 8", 1994 },
                    { 851, "Device 850", "Type 18", 2005 },
                    { 852, "Device 851", "Type 2", 1983 },
                    { 853, "Device 852", "Type 15", 1996 },
                    { 854, "Device 853", "Type 6", 2007 },
                    { 855, "Device 854", "Type 18", 1983 },
                    { 856, "Device 855", "Type 16", 1984 },
                    { 857, "Device 856", "Type 4", 2017 },
                    { 858, "Device 857", "Type 17", 2010 },
                    { 859, "Device 858", "Type 5", 1992 },
                    { 860, "Device 859", "Type 13", 1998 },
                    { 861, "Device 860", "Type 12", 1983 },
                    { 862, "Device 861", "Type 13", 1982 },
                    { 863, "Device 862", "Type 4", 2000 },
                    { 864, "Device 863", "Type 12", 2007 },
                    { 865, "Device 864", "Type 18", 2006 },
                    { 866, "Device 865", "Type 2", 2006 },
                    { 867, "Device 866", "Type 8", 2011 },
                    { 868, "Device 867", "Type 8", 2015 },
                    { 869, "Device 868", "Type 4", 2007 },
                    { 870, "Device 869", "Type 7", 1985 },
                    { 871, "Device 870", "Type 16", 2001 },
                    { 872, "Device 871", "Type 6", 2010 },
                    { 873, "Device 872", "Type 3", 2010 },
                    { 874, "Device 873", "Type 18", 2005 },
                    { 875, "Device 874", "Type 9", 1987 },
                    { 876, "Device 875", "Type 10", 1994 },
                    { 877, "Device 876", "Type 17", 1993 },
                    { 878, "Device 877", "Type 18", 2015 },
                    { 879, "Device 878", "Type 2", 1992 },
                    { 880, "Device 879", "Type 10", 1991 },
                    { 881, "Device 880", "Type 12", 2005 },
                    { 882, "Device 881", "Type 2", 1983 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 883, "Device 882", "Type 9", 2010 },
                    { 884, "Device 883", "Type 15", 2003 },
                    { 885, "Device 884", "Type 8", 2010 },
                    { 886, "Device 885", "Type 15", 2005 },
                    { 887, "Device 886", "Type 4", 1998 },
                    { 888, "Device 887", "Type 19", 2007 },
                    { 889, "Device 888", "Type 5", 2009 },
                    { 890, "Device 889", "Type 5", 1998 },
                    { 891, "Device 890", "Type 10", 1988 },
                    { 892, "Device 891", "Type 19", 1986 },
                    { 893, "Device 892", "Type 7", 1989 },
                    { 894, "Device 893", "Type 2", 1985 },
                    { 895, "Device 894", "Type 14", 2000 },
                    { 896, "Device 895", "Type 5", 2012 },
                    { 897, "Device 896", "Type 7", 1991 },
                    { 898, "Device 897", "Type 9", 2018 },
                    { 899, "Device 898", "Type 4", 2001 },
                    { 900, "Device 899", "Type 4", 2010 },
                    { 901, "Device 900", "Type 11", 2007 },
                    { 902, "Device 901", "Type 17", 1989 },
                    { 903, "Device 902", "Type 11", 1992 },
                    { 904, "Device 903", "Type 8", 1986 },
                    { 905, "Device 904", "Type 16", 1996 },
                    { 906, "Device 905", "Type 6", 1990 },
                    { 907, "Device 906", "Type 17", 1985 },
                    { 908, "Device 907", "Type 8", 1992 },
                    { 909, "Device 908", "Type 13", 2003 },
                    { 910, "Device 909", "Type 11", 2012 },
                    { 911, "Device 910", "Type 17", 2017 },
                    { 912, "Device 911", "Type 15", 1996 },
                    { 913, "Device 912", "Type 16", 1991 },
                    { 914, "Device 913", "Type 4", 2000 },
                    { 915, "Device 914", "Type 4", 2003 },
                    { 916, "Device 915", "Type 14", 1982 },
                    { 917, "Device 916", "Type 9", 1993 },
                    { 918, "Device 917", "Type 3", 1989 },
                    { 919, "Device 918", "Type 11", 1997 },
                    { 920, "Device 919", "Type 7", 1987 },
                    { 921, "Device 920", "Type 5", 1997 },
                    { 922, "Device 921", "Type 5", 1990 },
                    { 923, "Device 922", "Type 8", 2001 },
                    { 924, "Device 923", "Type 13", 1994 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 925, "Device 924", "Type 17", 1998 },
                    { 926, "Device 925", "Type 1", 2000 },
                    { 927, "Device 926", "Type 7", 1999 },
                    { 928, "Device 927", "Type 14", 1981 },
                    { 929, "Device 928", "Type 5", 1985 },
                    { 930, "Device 929", "Type 9", 2000 },
                    { 931, "Device 930", "Type 12", 1985 },
                    { 932, "Device 931", "Type 8", 2002 },
                    { 933, "Device 932", "Type 12", 2002 },
                    { 934, "Device 933", "Type 14", 2005 },
                    { 935, "Device 934", "Type 13", 2013 },
                    { 936, "Device 935", "Type 13", 2007 },
                    { 937, "Device 936", "Type 10", 1999 },
                    { 938, "Device 937", "Type 18", 1995 },
                    { 939, "Device 938", "Type 13", 2004 },
                    { 940, "Device 939", "Type 14", 1998 },
                    { 941, "Device 940", "Type 9", 2010 },
                    { 942, "Device 941", "Type 18", 2008 },
                    { 943, "Device 942", "Type 1", 1992 },
                    { 944, "Device 943", "Type 15", 2006 },
                    { 945, "Device 944", "Type 1", 2002 },
                    { 946, "Device 945", "Type 13", 1996 },
                    { 947, "Device 946", "Type 17", 1992 },
                    { 948, "Device 947", "Type 3", 2008 },
                    { 949, "Device 948", "Type 1", 1987 },
                    { 950, "Device 949", "Type 17", 2008 },
                    { 951, "Device 950", "Type 7", 2013 },
                    { 952, "Device 951", "Type 7", 2012 },
                    { 953, "Device 952", "Type 6", 2005 },
                    { 954, "Device 953", "Type 18", 1999 },
                    { 955, "Device 954", "Type 8", 2009 },
                    { 956, "Device 955", "Type 6", 1981 },
                    { 957, "Device 956", "Type 2", 1982 },
                    { 958, "Device 957", "Type 15", 2010 },
                    { 959, "Device 958", "Type 10", 1990 },
                    { 960, "Device 959", "Type 6", 1983 },
                    { 961, "Device 960", "Type 19", 1997 },
                    { 962, "Device 961", "Type 13", 2000 },
                    { 963, "Device 962", "Type 1", 1982 },
                    { 964, "Device 963", "Type 16", 1989 },
                    { 965, "Device 964", "Type 18", 2007 },
                    { 966, "Device 965", "Type 9", 1987 }
                });

            migrationBuilder.InsertData(
                table: "FactoryDevices",
                columns: new[] { "Id", "Name", "Type", "Year" },
                values: new object[,]
                {
                    { 967, "Device 966", "Type 14", 2018 },
                    { 968, "Device 967", "Type 10", 1998 },
                    { 969, "Device 968", "Type 18", 1985 },
                    { 970, "Device 969", "Type 15", 1987 },
                    { 971, "Device 970", "Type 1", 1980 },
                    { 972, "Device 971", "Type 1", 1987 },
                    { 973, "Device 972", "Type 13", 2013 },
                    { 974, "Device 973", "Type 4", 1983 },
                    { 975, "Device 974", "Type 17", 2017 },
                    { 976, "Device 975", "Type 1", 1982 },
                    { 977, "Device 976", "Type 7", 1986 },
                    { 978, "Device 977", "Type 12", 1998 },
                    { 979, "Device 978", "Type 11", 1990 },
                    { 980, "Device 979", "Type 5", 1997 },
                    { 981, "Device 980", "Type 2", 2000 },
                    { 982, "Device 981", "Type 3", 1996 },
                    { 983, "Device 982", "Type 9", 2018 },
                    { 984, "Device 983", "Type 19", 2016 },
                    { 985, "Device 984", "Type 12", 2010 },
                    { 986, "Device 985", "Type 1", 1985 },
                    { 987, "Device 986", "Type 19", 1997 },
                    { 988, "Device 987", "Type 14", 2011 },
                    { 989, "Device 988", "Type 19", 1998 },
                    { 990, "Device 989", "Type 11", 2016 },
                    { 991, "Device 990", "Type 6", 1994 },
                    { 992, "Device 991", "Type 6", 2008 },
                    { 993, "Device 992", "Type 6", 2009 },
                    { 994, "Device 993", "Type 13", 2004 },
                    { 995, "Device 994", "Type 6", 1991 },
                    { 996, "Device 995", "Type 13", 2000 },
                    { 997, "Device 996", "Type 14", 2012 },
                    { 998, "Device 997", "Type 2", 2005 },
                    { 999, "Device 998", "Type 14", 2002 },
                    { 1000, "Device 999", "Type 12", 1997 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "FactoryDevices",
                keyColumn: "Id",
                keyValue: 1000);
        }
    }
}
