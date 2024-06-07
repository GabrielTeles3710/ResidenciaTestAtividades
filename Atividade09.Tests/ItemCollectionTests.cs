using Atividade09;
using Xunit.Sdk;

namespace Atividade09.Tests;

public class ItemCollectionTests
{
    public ItemCollectionTests()
        {
            _itemCollection = new ItemCollection();
            _item1 = new Item("Teste1");
            _item2 = new Item("Teste2");
            _item3 = new Item("Teste3");
        }
    private ItemCollection _itemCollection;
    private Item _item1;
    private Item _item2;
    private Item _item3;

    [Fact]
    public void Add_itens_shoud_add_the_item(){
    _itemCollection.AddItem(_item1);
    List<Item> itens = _itemCollection.GetItems();
    Assert.Equal(_item1, itens[0]);
    }

    [Fact]
    public void Remote_itens_shoud_remove_the_especific_item(){
    _itemCollection.AddItem(_item1);
    _itemCollection.AddItem(_item2);
    _itemCollection.AddItem(_item3);
    List<Item> itens = _itemCollection.GetItems();
    _itemCollection.RemoveItem(_item2);
    Assert.DoesNotContain(_item2, itens);
    }

    [Fact]
    public void Get_Itens_shoud_return_correct_itens(){
    _itemCollection.AddItem(_item1);
    _itemCollection.AddItem(_item2);
    _itemCollection.AddItem(_item3);
    List<Item> itens = _itemCollection.GetItems();
    Assert.Equal(3, itens.Count);
    Assert.Contains(_item1, itens);
    Assert.Contains(_item2, itens);
    Assert.Contains(_item3, itens);
    }
}
