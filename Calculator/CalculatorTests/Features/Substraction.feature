Feature: Substraction
	In order to avoid silly mistakes
	As a math novice
	I want to be told the substraction of two numbers
	
@mytag
Scenario: Substract two numbers
	Given the minuend is 120
	And the subtrahend is 70
	When the minuend is substract from the subtrahend
	Then the substraction result should be 50
