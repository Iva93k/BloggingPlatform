# BloggingPlatform
Backend solution for a simple blogging platform. It uses a custom REST API for all requests. Web API can be consumed by any client.
## General functionality

> CRUD Blog posts

> Filter blog posts by tag

> List of all tags in the system

### List Blog Posts

	GET /api/posts
	
[https://localhost:44326/api/posts](https://localhost:44326/api/posts)

### LIst Blog Posts filtered by tag

	GET /api/posts?tag=value

[https://localhost:44326/api/posts?tag=tag1](https://localhost:44326/api/posts?tag=tag1)

### Get Blog Post

	GET /api/posts/slug

[https://localhost:44326/api/posts/blogging-platform-post](https://localhost:44326/api/posts/blogging-platform-post)

### Create Blog Posts

	POST /api/posts

[https://localhost:44326/api/posts](https://localhost:44326/api/posts)

Example request body:

	{
		"blogPost": {
			"title": "Internet Trends 2018",
			"description": "Ever wonder how?",
			"body": "An opinionated commentary, of the most important presentation of the year",
			"tagList": ["tag1", "tag2", "tag3"]
		}
	}
	
### Update Blog Post

	PUT /api/posts/slug

[https://localhost:44326/api/posts/blogging-platform-post](https://localhost:44326/api/posts/blogging-platform-post)

Example request body:

	{
		"blogPost": {
			"title": "New title"
		}
	}

### Delete Blog Post

	DELETE /api/posts/slug

[https://localhost:44326/api/posts/blogging-platform-post](https://localhost:44326/api/posts/blogging-platform-post)

### Get Tags

	GET /api/tags

[https://localhost:44326/api/tags](https://localhost:44326/api/tags)

# HOW TO RUN?

## Prerequisites

> SQL Server

> .NET Core 3.1

> Visual Studio

Application is configured for SQL Server, and connection string is configured to a local machine (you should have SQL Server installed on your machine).

After cloning or downloading the code, you should be able to run it immediately, just by running the project from Visual Studio (open the solution file *BloggingPlatform.sln*, set *BloggingPlatform.API* for the *Startup Project* and build/run).

Database will be created automatically by running application, and all migrations will be executed also. 
Beside that, when you run application, some initial data will be seed into a database automatically.


