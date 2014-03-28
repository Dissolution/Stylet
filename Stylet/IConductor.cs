﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stylet
{
    public interface IParent<out T>
    {
        IEnumerable<T> GetChildren();
    }

    public interface IHaveActiveItem<T>
    {
        T ActiveItem { get; set; }
    }

    public interface IChildDelegate
    {
        void CloseItem(object item, bool? dialogResult = null);
    }

    public interface IConductor<T>
    {
        void ActivateItem(T item);

        void DeactivateItem(T item);

        void CloseItem(T item);
    }
}
