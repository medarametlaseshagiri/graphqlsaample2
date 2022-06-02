namespace GraphQLSample.Context
{
    using GraphQLSample.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    namespace SuperHeroApi.Data.ContextConfigurations
    {
        public class SHPViewDlogWithAuditContextConfiguration : IEntityTypeConfiguration<SHPViewDlogWithAudit>
        {
            private Guid[] _ids;

            public SHPViewDlogWithAuditContextConfiguration(Guid[] ids)
            {
                _ids = ids;
            }

            public void Configure(EntityTypeBuilder<SHPViewDlogWithAudit> builder)
            {
                builder
                    .HasData(
                    new SHPViewDlogWithAudit
                    {
                        SBSB_ID = _ids[0].ToString(),
                        MEME_FIRST_NAME = "Batman",
                        Details = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                    },
                    new SHPViewDlogWithAudit
                    {
                        SBSB_ID = _ids[1].ToString(),
                        MEME_FIRST_NAME = "Luke Skywalker",
                        Details = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                    },
                    new SHPViewDlogWithAudit
                    {
                        SBSB_ID = _ids[2].ToString(),
                        MEME_FIRST_NAME = "Black Widow",
                        Details = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                    });
            }
        }
    }
}
