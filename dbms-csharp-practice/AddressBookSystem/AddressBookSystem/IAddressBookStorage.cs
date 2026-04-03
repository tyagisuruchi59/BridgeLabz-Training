using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public interface IAddressBookStorage
    {
        Task SaveAsync(List<Contact> contacts);
        Task<List<Contact>> LoadAsync();
    }
}
