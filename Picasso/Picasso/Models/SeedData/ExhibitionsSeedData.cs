using Microsoft.EntityFrameworkCore;
using Picasso.Model;

namespace Picasso.Models.SeedData
{
    public static class ExhibitionsSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExhibitionManagementDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ExhibitionManagementDbContext>>()))
            {
                // Look for any Exhibitions.
                if (context.Exhibitions.Any())
                {
                    return;   // DB has been seeded
                }

                context.Exhibitions.AddRange(
                    new Exhibitions
                    {
                        ExhibitionName = "以土為名的抽象共感－陶藝創作展",
                        ExhibitionType = "陶藝展",
                        StartDate = DateTime.Parse("2023/11/14"),
                        EndDate = DateTime.Parse("2023/12/16"),
                        Organizer = "中央大學人文藝術中心",
                        CoOrganizer = @"國立臺灣藝術大學工藝設計學系、國立清華大學藝術與設計學系、國立臺北科技大學文化事業發展系",
                        ExhibitionDescription = @"陶瓷是人類最為精彩的發明之一，自古以來土與火結合的藝術，成就了人類文明最為綿長而燦爛的篇章。
                                                現今的藝術家們持續以陶瓷為媒介，將內在的好奇心、想像力和創造力在以土為名的創作旅程中延續。
                                                黏土材料是構成陶瓷作品的骨架，建構在其上的則是藝術家的感性抒發。藝術家的個性和作品表現息息相關，感興趣的題材與元素必定與自身有著緊密的關聯。
                                                創作者和材料之間也是平行對應的關係，九位藝術家對於黏土的喜好與情感皆源自於創作實踐過程中的體會，不止於對陶瓷單一維度的思考和觀看，更圍繞著對場域與位面的多元洞析。",
                        ExhibitionStatus = "通過審核",
                        Image = "",
                        CreateDate = DateTime.Parse("2023/11/25 00:00:00")
                    },
                    new Exhibitions
                    {
                        ExhibitionName = "島史：湛藍圖景 - 2023劉子平個展",
                        ExhibitionType = "畫展",
                        StartDate = DateTime.Parse("2023/09/26"),
                        EndDate = DateTime.Parse("2023/10/28"),
                        Organizer = "中央大學人文藝術中心",
                        CoOrganizer = @"桃園市政府文化局、藍瓦空間",
                        ExhibitionDescription = @"",
                        ExhibitionStatus = "通過審核",
                        Image = "",
                        CreateDate = DateTime.Parse("2023/11/25 00:00:00")
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
