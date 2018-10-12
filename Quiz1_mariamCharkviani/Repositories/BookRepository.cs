using System;
using System.Collections.Generic;
using Quiz1_mariamCharkviani.Models;

namespace Goodreads.Repositories
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
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
            };
        }
    }
}