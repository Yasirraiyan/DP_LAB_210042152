Strategy Pattern হল একটি behavioral design pattern যা আমাদের কোডে বিভিন্ন algorithm বা behavior interchangeably চালানোর সুবিধা দেয়। অর্থাৎ, একই কাজ করার জন্য বিভিন্ন উপায় (algorithm) থাকতে পারে এবং তুমি runtime এ সেই algorithm গুলোর মধ্যে যেকোনো একটি বেছে নিতে পারবে।

কেন দরকার?
ধরা যাক, তোমার একটা প্রোগ্রাম আছে যা বিভিন্ন পদ্ধতিতে কোন কাজ করতে পারে, কিন্তু তুমি চাও যে কোন একটি পদ্ধতি ডায়নামিকভাবে পরিবর্তন করা যাক, এবং কোড যেন বেশি জটিল না হয়। তখন Strategy pattern ব্যবহার করা হয়।

কীভাবে কাজ করে?

প্রথমে একটি Strategy ইন্টারফেস/abstract class থাকবে যেটা behavior (algorithm) define করে।

তারপর আলাদা আলাদা ক্লাস থাকবে যা ঐ Strategy ইন্টারফেস ইমপ্লিমেন্ট করে (অর্থাৎ বিভিন্ন algorithm এর ক্লাস)।

তোমার main context class/বস্তু থাকবে, যেখানে Strategy টাইপের একটা ফিল্ড থাকবে।

তুমি runtime এ ঐ ফিল্ডে বিভিন্ন strategy সেট করবে এবং কাজ করাবে।

কিভাবে চিনতে পারব যে কোন Scenario তে Strategy Pattern লাগবে?
যখন:

তোমার problem এ একই কাজের জন্য একাধিক algorithm থাকে। (যেমন Sorting এর জন্য Bubble sort, Quick sort, Merge sort)

তুমি চাই যে program execution এর সময় algorithm পরিবর্তন করা যাক।

তোমার code এর মধ্যে if-else বা switch-case এর মাধ্যমে অনেক algorithm handle করার জায়গা আছে, যা খুব জটিল ও onderhoud (maintenance) কঠিন করে।

তুমি চাও কোডটা Open for Extension, Closed for Modification (OCP) প্রিন্সিপল অনুসারে থাকুক — অর্থাৎ নতুন algorithm যোগ করতে গিয়ে পুরনো কোডে হাত দিতে না হয়।

