using Assurity_test.Base;
using Assurity_test.Controller;
using Assurity_test.Model;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Assurity_test.FeatureSteps
{
    [Binding]
    public class CategoryDetailsSteps: RestTestBase
    {
        private readonly CategoryDetailsController _categoryDetailsController;
        public CategoryDetails _categoryDetails;
        public string _categoryId;
        public string _catalogueValue;
        public string _promotionName;
        public string _promotionText;
        public string _categoryDetailsResponse;
        public CategoryDetailsSteps(ApiScenarioContextKeys apiScenarioContextKeys, CategoryDetailsController categoryDetailsController) : base(apiScenarioContextKeys)
        {
            _categoryDetailsController = categoryDetailsController;
          

        }

        [Given(@"I have the category id (.*)")]
        public void GivenIHaveTheCategoryId(string categoryId)
        {
            _categoryId = categoryId;
        }
        
        [Given(@"I have the catalogue value as (.*)")]
        public void GivenIHaveTheCatalogueValueAs(string catalogueValue)
        {
            _catalogueValue = catalogueValue;
        }
        
       
        
        [When(@"I call the Get Category Details API")]
        public void WhenICallTheGetCategoryDetailsAPI()
        {
            _apiScenarioContextKeys._restResponse = _categoryDetailsController.GetCategoryDetails(_categoryId,_catalogueValue);
            _categoryDetails = JsonConvert.DeserializeObject<CategoryDetails>(_apiScenarioContextKeys._restResponse.Content);

        }

        [Then(@"the respone code equals (.*)")]
        public void ThenTheResponeCodeEquals(string statusCode)
        {
            Assert.AreEqual(statusCode, _apiScenarioContextKeys._restResponse.StatusCode.ToString());
        }
        
        [Then(@"the response has category name as (.*)")]
        public void ThenTheResponseHasCategoryNameAs(string categoryName)
        {
            Assert.AreEqual(categoryName, _categoryDetails.Name, "Incorrect Category Name");
        }
        
        [Then(@"the response has CanRelist as (.*)")]
        public void ThenTheResponseHasCanRelistAs(string canRelist)
        {
            Assert.AreEqual(_categoryDetails.CanRelist.ToString(), canRelist, "Incorrect CanRelist Value");
        }
        
       
      

        [Then(@"the promotion (.*) contains description (.*)")]
        public void ThenThePromotionContainsDescription(string promotionName, string promotionText)
        {
            var containsPromotionText = checkForPromotionText(promotionName, promotionText);
            Assert.AreEqual(containsPromotionText, true, "Promotion Name with Promotion text is not found");
        }

        public bool checkForPromotionText(string promotionName, string promotionText)
        {
            bool isPromotionTextContained = false;
            foreach (Promotion promotion in _categoryDetails.Promotions)
            {
                if (promotion.Name.Equals(promotionName) && promotion.Description.Contains(promotionText))
                {
                    isPromotionTextContained = true;
                    break;
                }

            }
            return isPromotionTextContained;
        }
    }
}
