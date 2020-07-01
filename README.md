*A game design concept [as described by](http://www.lostgarden.com/2014/12/loot-drop-tables.html) Daniel Cook. ([article mirror](http://web.archive.org/web/20141228094543/http://www.lostgarden.com/2014/12/loot-drop-tables.html))*

Loot Drop Tables are a content driven approach to defining what kind of loot you want to drop and with what chance.

**Quick Overview**
- Define your tables in JSON or XML *(or generate them on the fly!)*
- Weighted drop table allows you to set drop chance of each loot item
- `DropTableSampler` picks random loot out of your table based on weights

**Loot Table examples**
- [XML](https://github.com/HermansGameDev/LootDropTables/blob/master/LootDropTableExample/WeaponDrops.xml)
- [JSON](https://github.com/HermansGameDev/LootDropTables/blob/master/LootDropTableExample/WeaponDrops.json)
