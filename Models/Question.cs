using System.Collections.Generic;

namespace TriviaBackend.Models
{
public class Question
{
	public long QuestionId { get; set; }
	public string QuestionDescription { get; set; }
	public string AnswerDescription { get; set; }
	public Topics Topic { get; set; }
	
	public Dificulties Dificulty { get; set;}
	public enum Topics
	{
		computers,
		history,
		geography,
		movies,
		literature,
		sports,
		television,
		games,
		celebrities,
		humanities,
		religion,
		tech,
		generalKnowledge
	}
	
	public enum Dificulties {
		easy,
		medium,
		hard
	}
	
	public static IEnumerable<Question> questionSeed(){
		return new List<Question>(){
			new Question {
				QuestionId = 1,
				QuestionDescription = "What company is the largest producer of computer software for the personal computer?",
				AnswerDescription = "Microsoft",
				Topic = Topics.computers,
				Dificulty = Dificulties.easy
			},
			new Question {
				QuestionId = 2,
				QuestionDescription = "If the telephone company added one more digit to all the phone numbers in one area code, how many new phone numbers could potentially be added?",
				AnswerDescription = "90,000,000",
				Topic = Topics.computers,
				Dificulty = Dificulties.medium
			},
			new Question {
				QuestionId = 3,
				QuestionDescription = "Can you name three countries that begin with \"J\"?",
				AnswerDescription = "JAPAN / JORDAN / JAMAICA",
				Topic = Topics.geography,
				Dificulty = Dificulties.easy
			},
			new Question {
				QuestionId = 4,
				QuestionDescription = "Can you name the two land-locked countries of South America?",
				AnswerDescription = "BOLIVIA / PARAGUAY",
				Topic = Topics.geography,
				Dificulty = Dificulties.medium
			},
			new Question {
				QuestionId = 5,
				QuestionDescription = "The suspenseful 1963 Alfred Hitchcock film, the Birds, was set in what San Francisco Bay coastal town?",
				AnswerDescription = "Bodega Bay, in Sonoma county",
				Topic = Topics.movies,
				Dificulty = Dificulties.hard
			}
		};
	}
}	
}
