using System;
using System.Collections.Generic;
using Quiz1_mariamCharkviani.Models;
using Quiz1_mariamCharkviani.ViewModel;

namespace Goodreads.Repositories
{
    public class AuthorRepository
    {
        public IEnumerable<Author> GetAuthors()
        {
            return new List<Author>
            {
                new Author
                {
                    Id = 1,
                    FullName = "Stephen King",
                    DateOfBirth = new DateTime(1947, 9, 21),
                    About = @"Stephen Edwin King was born the second son of Donald and Nellie Ruth Pillsbury King. After his father left them when Stephen was two, he and his older brother, David, were raised by his mother. Parts of his childhood were spent in Fort Wayne, Indiana, where his father's family was at the time, and in Stratford, Connecticut. When Stephen was eleven, his mother brought her children back to Durham, Maine, for good. Her parents, Guy and Nellie Pillsbury, had become incapacitated with old age, and Ruth King was persuaded by her sisters to take over the physical care of them. Other family members provided a small house in Durham and financial support. After Stephen's grandparents passed away, Mrs. King found work in the kitchens of Pineland, a nearby residential facility for the mentally challenged.
                    Stephen attended the grammar school in Durham and Lisbon Falls High School, graduating in 1966. From his sophomore year at the University of Maine at Orono, he wrote a weekly column for the school newspaper, THE MAINE CAMPUS.He was also active in student politics, serving as a member of the Student Senate.He came to support the anti - war movement on the Orono campus, arriving at his stance from a conservative view that the war in Vietnam was unconstitutional.He graduated in 1970, with a B.A. in English and qualified to teach on the high school level.A draft board examination immediately post - graduation found him 4 - F on grounds of high blood pressure, limited vision, flat feet, and punctured eardrums.
                    He met Tabitha Spruce in the stacks of the Fogler Library at the University, where they both worked as students; they married in January of 1971.As Stephen was unable to find placement as a teacher immediately, the Kings lived on his earnings as a laborer at an industrial laundry, and her student loan and savings, with an occasional boost from a short story sale to men's magazines.
                    Stephen made his first professional short story sale('The Glass Floor') to Startling Mystery Stories in 1967.Throughout the early years of his marriage, he continued to sell stories to men's magazines. Many were gathered into the Night Shift collection or appeared in other anthologies.
                    In the fall of 1971, Stephen began teaching English at Hampden Academy, the public high school in Hampden, Maine.Writing in the evenings and on the weekends, he continued to produce short stories and to work on novels."
                },

                new Author
                {
                    Id = 2,
                    FullName = "Khaled Hosseini",
                    DateOfBirth = new DateTime(1965, 3, 4),
                    About = @"Hosseini was born in Kabul, Afghanistan, in 1965. In 1970 Hosseini and his family moved to Iran where his father worked for the Embassy of Afghanistan in Tehran. In 1973 Hosseini's family returned to Kabul, and Hosseini's youngest brother was born in July of that year.
                    In 1976, when Hosseini was 11 years old, Hosseini's father obtained a job in Paris, France, and moved the family there. They were unable to return to Afghanistan because of the Saur Revolution in which the PDPA communist party seized power through a bloody coup in April 1978. Instead, a year after the Soviet invasion of Afghanistan, in 1980 they sought political asylum in the United States and made their residence in San Jose, California.
                    Hosseini graduated from Independence High School in San Jose in 1984 and enrolled at Santa Clara University, where he earned a bachelor's degree in biology in 1988. The following year, he entered the University of California, San Diego, School of Medicine, where he earned his M.D. in 1993. He completed his residency in internal medicine at Cedars-Sinai Medical Center in Los Angeles in 1996. He practiced medicine for over ten years, until a year and a half after the release of The Kite Runner.
                    Hosseini is currently a Goodwill Envoy for the United Nations High Commissioner for Refugees(UNHCR).He has been working to provide humanitarian assistance in Afghanistan through the Khaled Hosseini Foundation.The concept for the foundation was inspired by the trip to Afghanistan that Hosseini made in 2007 with UNHCR.
                    He lives in Northern California with his wife, Roya, and their two children(Harris and Farah)."
                },

                new Author
                {
                    Id = 3,
                    FullName = "Kurt Vonnegut",
                    DateOfBirth = new DateTime(1922, 11, 11),
                    About = @"Kurt Vonnegut, Junior was an American novelist, satirist, and most recently, graphic artist. He was recognized as New York State Author for 2001-2003. 
                    He was born in Indianapolis, later the setting for many of his novels.He attended Cornell University from 1941 to 1943, where he wrote a column for the student newspaper, the Cornell Daily Sun.Vonnegut trained as a chemist and worked as a journalist before joining the U.S.Army and serving in World War II.
                    After the war, he attended University of Chicago as a graduate student in anthropology and also worked as a police reporter at the City News Bureau of Chicago.He left Chicago to work in Schenectady, New York in public relations for General Electric.He attributed his unadorned writing style to his reporting work.
                    His experiences as an advance scout in the Battle of the Bulge, and in particular his witnessing of the bombing of Dresden, Germany whilst a prisoner of war, would inform much of his work. This event would also form the core of his most famous work, Slaughterhouse-Five, the book which would make him a millionaire.This acerbic 200-page book is what most people mean when they describe a work as 'Vonnegutian' in scope.
                    Vonnegut was a self-proclaimed humanist and socialist (influenced by the style of Indiana's own Eugene V. Debs) and a lifelong supporter of the American Civil Liberties Union.
                    The novelist is known for works blending satire, black comedy and science fiction, such as Slaughterhouse-Five (1969), Cat's Cradle (1963), and Breakfast of Champions (1973) "
                },

                new Author
                {
                    Id = 4,
                    FullName = "Clifford D. Simak",
                    DateOfBirth = new DateTime(1904, 8, 3),
                    About = "He was honored by fans with three Hugo awards and by colleagues with one Nebula award and was named the third Grand Master by the Science Fiction and Fantasy Writers of America (SFWA) in 1977."
                },
            };
        }

        public RandomAuthorViewModel GetRandomAuthor()
        {
            return new RandomAuthorViewModel
            {
                Author = new Author
                {
                    Id = 2,
                    FullName = "Khaled Hosseini",
                    DateOfBirth = new DateTime(1965, 3, 4),

                },

                Books = new List<Book>
                {
                    new Book
                    {
                        Id = 1,
                        ISBN = "1594489505",
                        Title = "The Kite Runner",
                        DatePublished = new DateTime(2014, 5, 1),
                        NumberOfPages = 371,
                        Summary =
                            @"Amir is the son of a wealthy Kabul merchant, a member of the ruling caste of Pashtuns. Hassan, his servant and constant companion, is a Hazara, a despised and impoverished caste. Their uncommon bond is torn by Amir's choice to abandon his friend amidst the increasing ethnic, religious, and political tensions of the dying years of the Afghan monarchy, wrenching them far apart. But so strong is the bond between the two boys that Amir journeys back to a distant world, to try to right past wrongs against the only true friend he ever had.
                            The unforgettable, heartbreaking story of the unlikely friendship between a wealthy boy and the son of his father’s servant, The Kite Runner is a beautifully crafted novel set in a country that is in the process of being destroyed. It is about the power of reading, the price of betrayal, and the possibility of redemption; and an exploration of the power of fathers over sons—their love, their sacrifices, their lies.
                            A sweeping story of family, love, and friendship told against the devastating backdrop of the history of Afghanistan over the last thirty years, The Kite Runner is an unusual and powerful novel that has become a beloved, one-of - a - kind classic. "
                    },
                    new Book
                    {
                        Id = 2,
                        ISBN = "1594480001",
                        Title = "A Thousand Splendid Suns",
                        DatePublished = new DateTime(2007, 6, 1),
                        NumberOfPages = 372,
                        Summary =
                            @"A Thousand Splendid Suns is a breathtaking story set against the volatile events of Afghanistan's last thirty years—from the Soviet invasion to the reign of the Taliban to post-Taliban rebuilding—that puts the violence, fear, hope, and faith of this country in intimate, human terms. It is a tale of two generations of characters brought jarringly together by the tragic sweep of war, where personal lives—the struggle to survive, raise a family, find happiness—are inextricable from the history playing out around them.
                            Propelled by the same storytelling instinct that made The Kite Runner a beloved classic, A Thousand Splendid Suns is at once a remarkable chronicle of three decades of Afghan history and a deeply moving account of family and friendship. It is a striking, heart-wrenching novel of an unforgiving time, an unlikely friendship, and an indestructible love—a stunning accomplishment. "
                    }
                }
            };
        }
    }
}