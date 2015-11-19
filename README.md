### Backend

Using ASP.NET vNext

Mac instructions:

```
dnx restore
dnx web
```

the "web" will run the project then you can call the mockup api like this:

current calls:

```
 GET api/questions/5
 GET api/questions/topic/1
 GET api/questions/difficulty/1
```

current enums:

	public enum Topics
	{
		computers = 0,
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
		easy = 0,
		medium,
		hard
	}

