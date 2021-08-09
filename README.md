# AssurityTest
Pre-req: Visual Studio 2019 or any latest version


1. Clone the repo from github, git clone https://github.com/sruthyjosep/AssurityTest.git
2. Open the Assurity_test.sln file. Project gets opened in Visual Studio
3. Build> Clean Solution
4. Build> Build Solution 
5. Run the test that is discovered in the test explorer
6. Test would fail as the acceptance criteria is not met for the promotion with description name

**Acceptance Criteria:**
Name = "Carbon credits"
CanRelist = true
The Promotions element with Name = "**Gallery**" has a Description that contains the text "**2x larger image**"


**JSON Response for the request https://api.tmsandbox.co.nz/v1/Categories/6327/Details.json?catalogue=false**
{
    "CategoryId": 6327,
    "Name": "Carbon credits",
    "Path": "/Business-farming-industry/Carbon-credits",
    "CanListAuctions": true,
    "CanListClassifieds": true,
    "CanRelist": true,
    "LegalNotice": "Compliance Declaration\nI confirm that these carbon credits are certified and registered with a carbon credits registry. ",
    "DefaultDuration": 14,
    "AllowedDurations": [
        2,
        3,
        4,
        5,
        6,
        7,
        10,
        14
    ],
    "Fees": {
        "Bundle": 15.0000,
        "EndDate": 0.2500,
        "Feature": 10.0000,
        "Gallery": 2.0000,
        "Listing": 29.0000,
        "Reserve": 0.2500,
        "Subtitle": 0.5500,
        "TenDays": 0.2500,
        "ListingFeeTiers": [
            {
                "MinimumTierPrice": 0,
                "FixedFee": 29.00
            }
        ],
        "SecondCategory": 0.9900
    },
    "FreePhotoCount": 20,
    "MaximumPhotoCount": 20,
    "IsFreeToRelist": true,
    "Promotions": [
        {
            "Id": 1,
            "Name": "Basic",
            "Description": "Lowest position in category",
            "Price": 0.0000,
            "MinimumPhotoCount": 0
        },
        {
            "Id": 2,
            "Name": "Gallery",
            "Description": "Good position in category",
            "Price": 2.0000,
            "OriginalPrice": 2.0000,
            "MinimumPhotoCount": 0
        },
        {
            "Id": 3,
            "Name": "Feature",
            "Description": "Better position in category",
            "Price": 10.0000,
            "OriginalPrice": 10.0000,
            "Recommended": true,
            "MinimumPhotoCount": 0
        },
        {
            "Id": 4,
            "Name": "Feature Combo",
            "Description": "Best position in category \nIncludes benefits of Feature \nHighlights listing in search results",
            "Price": 15.0000,
            "OriginalPrice": 15.0000,
            "MinimumPhotoCount": 0
        }
    ],
    "EmbeddedContentOptions": [],
    "MaximumTitleLength": 80,
    "AreaOfBusiness": 1,
    "DefaultRelistDuration": 7,
    "CanUseCounterOffers": true
}
