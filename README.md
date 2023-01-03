======================================
Requirements Specification
======================================

We buy and sell only the finest goods.
Unfortunately, our goods are constantly degrading in quality as they approach their sell by date.
We need to put in place a  system that updates our inventory.
Your have to take into account:
- All items have a “Sell In” value which is the number of days before an item expires.
- All items have a “Quality” value which denotes how valuable the item is.
- At the end of each day, our system lowers both values for every item.
- Once the item has expired, Quality degrades twice as fast.
- The Quality of an item is never negative.
- The Quality of an item is never more than 50.

We also have some special items like:
- "Camembert" actually increases in Quality the older it gets.
- "Ricotta" items degrade in Quality twice as fast as normal items.
- "Pokemon card rare collection ", being a legendary item, does not expire and never decreases in Quality.
- "Concert Backstage passes", increases in Quality as its Sell In value approaches:
Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but quality drops to 0 after the concert.


Just for clarification, an item can never have its Quality increase above 50, however
legendary items Quality is 80 and it never alters.

**Recommendations**
- Take you time to think about your design decisions ~30 minutes.
- A running solution with less features will be considered better than a fully implemented buggy solutions.
- Name your variables/methods wisely.
- Unit tests are very valuables regarding evaluation.

