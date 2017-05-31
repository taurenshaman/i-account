using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAccount.Core.Interfaces {
  /// <summary>
  /// T: ulong, string, GUID/UUID
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IUser<T> {
    /// <summary>
    /// unique id
    /// </summary>
    T Id { get; set; }
    /// <summary>
    /// unique user name
    /// </summary>
    string UserName { get; set; }

  }

}
