Feature: Calculator
	

Scenario: Verify that the Calculator application can be used to divide two numbers
	Given that an application is successfully loaded
	When a user navigates to the first field and fill-in '4'
	And a user navigates to the second field and fill-in '2'
	And a user clicks on Divide button
	Then the result should be 2 on the screen


