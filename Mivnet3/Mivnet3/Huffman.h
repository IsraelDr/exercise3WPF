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
	priority_queue<HuffmanNode*, vector<HuffmanNode*>, compareNode> pQueue;//priorityQueue

	string encode(string sourceFileName, string destFileName)
	{}
	string decode(string sourceFileName, string destFileName)
	{}
	int* buildTable(string text,int size) //build frequency table SD
	{
		int * frequencyTableTemp = new int[256];
		for (int i = 0; i < size; i++)
		{
			frequencyTableTemp[(text[i])]++;
		}
		return frequencyTableTemp;
	}
	void buildTree(int* frequencyTable, int size)//bulding the huffman tree using a priority queue
	{											//SD
		buildPriorityQueueHelp(frequencyTable,size);
		HuffmanNode* combined,*first,*second;
		while (pQueue.size()>=2)
		{
			first = pQueue.top();
			pQueue.pop();
			second = pQueue.top();
			pQueue.pop();
			combined = new HuffmanNode('?',first->frequency+second->frequency,first,second);
			pQueue.push(combined);
		}
	}
	void buildPriorityQueueHelp(int* frequencyTable,int size)//build Priority Queue SD
	{
		for (int i = 0; i < size; i++)
		{
			pQueue.push(new HuffmanNode((char)(i),frequencyTable[i]));
		}
	}
};


