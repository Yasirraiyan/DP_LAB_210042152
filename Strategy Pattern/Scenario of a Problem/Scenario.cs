ধরা যাক তুমি একটা Payment System বানাচ্ছো যেখানে ইউজার বিভিন্ন payment method ব্যবহার করতে পারে — যেমন Credit Card, PayPal, Mobile Payment। প্রতিটি payment method এর আলাদা আলাদা পদ্ধতি (algorithm) আছে।

এখন তোমার requirement:

ইউজার runtime এ যেকোনো payment method বেছে নিতে পারবে।

নতুন payment method যোগ করতে গেলে পুরনো কোডে খুব বেশি পরিবর্তন করতে হবে না।

কোড যেন পরিষ্কার ও maintainable হয়।
