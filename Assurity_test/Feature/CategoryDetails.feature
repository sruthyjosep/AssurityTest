Feature: CategoryDetails
	
Scenario Outline: Get Category Details(+ve scenario)
	Given I have the category id <CategoryId>
	And I have the catalogue value as <Catalogue>
	When I call the Get Category Details API
	Then the respone code equals <Status>
	And the response has category name as <CategoryName>
	And the response has CanRelist as <CanRelist>
	And the promotion <PromotionName> contains description <Promotiontext>
	

	Examples: 
	|CategoryId	|Catalogue|Status|CategoryName		|CanRelist|PromotionName|Promotiontext		|
	|6327		|false	  |	OK	 |Carbon credits	|True    |Gallery		|2x larger image	    |

