[Slide 2]

# Intro

When most peeps hear: "write unit tests", they roll their eyes. 
When you hear TDD, you probably think of the pointless example: Write a test around an empty class, then write as little code as possible to make it pass.

Now the pointless example is frustrating (at least to me) but it does give you good practise. 
What I want to share today is a more practical example of how to apply it.

Reasons to write unit tests:
Nr one reason often punted: To test your code works as expected, duh!

I want to give you a different perspective:
To use it as a tool during development. 
1. Figure out the code flow and ensure you are covering all the specifications
2. Identify gaps in your understanding or specs that need more though
3. Take the time and setup out of "manual test" at the start

The fact that your code is tested becomes a by-product of the development process. How neat is that!

[Slide 3]

## Using unit tests to figure out the code flow:
Before you start writing code you need to be sure you understand what it is you need to do. What are the requirements for this piece of code. We often think we have it in our heads, but that way we can't see the gaps. An effective way to ensure your understanding is correct and to spot gaps is to write things down. Why not write it down in the repo right from the start?
So, before you start with your development you should create a unit test file. (I know this sounds a lot like we're heading into the pointles example. Just bear with me.) In this file you can begin to write down all the specs and flows. Re-read as you go along, and ask your colleagues for a review. This has the added bonus of shared understanding and allignment. You can do this as in-line comments.

### Write out test cases
In the unit test file, the first thing we will do is write out our test cases. 
1. Positive flows: First list all the related steps and actions
2. Negative flows: What should happen when things fail? What shouldn't happen when things fail?

List specific actions. When you are tempted to use the word "and" in the result definition, it usually indicates that a seperate test is required.

I like to use the `Given_When_Then`` naming convention: 

"Given" a setup, 

"When" a specific thing happens, 

"Then" the following result is expected. 

Keeping this in mind helps me formulate the behaviour I want to test and what a verifyable result will be. It informs the test setup that will be required. 

## Filling in the code
The next thing you can do is write out the code flow in your implementation using the understanding you gained from the first step. I like to just add it as methods on interfaces. This helps you think about how the class you are implementing needs to interact with its dependencies and what objects you may need to effectively pass information between dependencies.

## Developing dependencies
You can repeat this process for every dependency down the line. At some point you'll need integration testing but we'll get to that.

[Slide 4] Example time!


[Slide 5]

## Using unit tests to speed up development
Unit test frameworks allow you to have a running program without the need to have everything set up correctly. Think about the VPN for example, or a DB connection.
It allows you to interact with only the code you are working on, without the need for all the surrounding code and services to function.
Top tip*: you can use a unit test file as a scratch pad, create the test file and chuck it when you are done. Let's use an example of integrating with a third party API. You can use that unit test file to:
* test your connection details, 
* check that you are passing the params or body in correctly
* check the response and ensure your response object is defined correctly. 

Imagine if you had to figure all of that out by starting up the API and front end, logging in, navigating to the correct page, fill in the form, and do that every time you need to make a change. That takes up a lot of time. 

### Testing integrations unsing unit tests
The API example shows how you can use the unit tests as integration tests.

[Slide 6]  EasyLending Integration tests. EasyLending database context tests

[Slide 7]

## Technicalities 
## 1. What level should I be testing at?
A single level at a time. These are unit tests. You are testing small pockets of logic at a time. Yes, larger integration tests are necessary, but thankfully we are not talking about them right now...
## 2. Using test stub effectively?
Some people say that if you mock things out you are just testing the mock implementation. You need to use the mock or stub for the right purpose.
Remember that you are using the mock to:
* Allow the code to run through. 
* To test decision tree logic: you use the mock to return a specific result in order to test a specific logic path.
* Simulate exceptions occuring in downstream dependencies

[Slide 8] using Moq to appropriately 


[Slide 9] 

## Practising the testable code mindset
1. What does untestable code look like?
2. How to test integrations?