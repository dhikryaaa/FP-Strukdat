using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStrukDatBeta;

public class Node
{
    public Buku Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(Buku data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BST
{
    private Node root;

    public BST()
    {
        root = null;
    }

    public void Insert(Buku data)
    {
        root = InsertRec(root, data);
    }

    private Node InsertRec(Node root, Buku data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (string.Compare(data.ISBN, root.Data.ISBN) < 0)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (string.Compare(data.ISBN, root.Data.ISBN) > 0)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    public Buku Search(string isbn)
    {
        Node node = SearchRec(root, isbn);

        return node?.Data;
    }

    private Node SearchRec(Node root, string isbn)
    {
        if (root == null || root.Data.ISBN == isbn)
        {
            return root;
        }

        if (string.Compare(isbn, root.Data.ISBN) < 0)
        {
            return SearchRec(root.Left, isbn);
        }

        return SearchRec(root.Right, isbn);
    }

    public void InOrderTraversal()
    {
        InOrderRec(root);
    }

    private void InOrderRec(Node root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.WriteLine(root.Data);
            InOrderRec(root.Right);
        }
    }
}