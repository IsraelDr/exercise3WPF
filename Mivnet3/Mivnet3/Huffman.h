#pragma once
#pragma once
#include <string>
#include <vector>
#include <queue>

class compareNode
{
public:
	bool operator()(HuffmanNode* const & n1, HuffmanNode* const & n2)
	{
		return n1->frequency > n2->frequency;
	}
};

class HuffmanNode
{
	string str;
	int frequency;
	//left;
	//right;

	friend class compareNode;

};

class treeHuffman
{
public:
	string encode(string sourceFileName, string destFileName)
	{}
	string decode(string sourceFileName, string destFileName)
	{}
	int* buildTable(string text,int size) //build frequency table
	{
		int * frequencyTableTemp = new int[256];
		for (int i = 0; i < size; i++)
		{
			frequencyTableTemp[(text[i])]++;
		}
		return frequencyTableTemp;
	}
	void buildTree(int* frequencyTable, int size)
	{

	}
};


