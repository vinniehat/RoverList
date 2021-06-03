using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RoverList {
    public class RoverList<T> : RoverListBase<T> {
        // Add any variables you need here


        private int count { get; set; }

        public override int Count => count; // THIS IS ONLY A GETTER DUE TO THE OVERRIDE

        public RoverList() {
            count = 0;
        }


        public override void Add(T data) {
            Node node = new Node(data, null);
            if (head == null) {
                head = node;
                current = head;
            } else {
                current.Next = node;
                current = current.Next;
            }
            count++;
        }

        public override void Add(int position, T data) {
            // Node node = new Node(data, null);
            // if (head == null) {
            //     head = node;
            //     current = head;
            // } else {
            //     var index = 0;
            //
            //
            //     while (current != null && index < position) { // This loop will break at the END of the current OR if it meets the position
            //         if (index != position) {
            //             current = current.Next;
            //         } else if (index == position) {
            //             break;
            //         }
            //
            //         index++;
            //     }
            //
            //     current = node;
            // }
            // count++;
            Node node = new Node(data, null);
            var tempHead = head;
            var index = 0;
            
            if (head == null) {
                head = node;
                current = head;
            }
            
            if (position == 0) {
                var oldHead = head;
                head = node;
                head.Next = oldHead;
            } else {
                for (int i = 0; i < position - 1; i++) {
                    tempHead = tempHead.Next;
                    index++;
                }

                var oldNext = tempHead.Next; // Capture the remaining data
                tempHead.Next = node; // Overwrite that with the new data/node
                tempHead = tempHead.Next; // Progress through the next interval
                tempHead.Next = oldNext; // Insert the remaining data

                head = tempHead; // Overwrite the head with the new/temp head
            }
            count++;
        }

        public override void Clear() {
            head = null;
            count = 0;
        }

        public override T ElementAt(int position) {
            if (position < 0 || position >= Count) throw new IndexOutOfRangeException();
            int pos = 0;
            current = head;
            while (pos != position) {
                pos++;
                if(current.Next != null) current = current.Next;
            }
            return current.Data;
        }

        public override void ListNodes() {
            var x = head;

            while (x != null) {
                Console.WriteLine(x.Data);
                x = x.Next;
            }
        }

        public override bool RemoveAt(int position) {
            if (position == 0) {
                head = head.Next;
            } else {
                // Make sure you loop over until you get to the position
                // Shifting over

                var tempHead = head;

                for (int i = 0; i < position - 1; i++) {
                    if (tempHead == null) break;
                    if (tempHead.Next == null) tempHead = null;
                    else tempHead.Next = tempHead.Next.Next;
                    

                }
            }

            return true;
        }
    }
}