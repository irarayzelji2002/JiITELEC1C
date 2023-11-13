DROP DATABASE ITELEC1C_FinalLabAct1_Ji;
CREATE DATABASE ITELEC1C_FinalLabAct1_Ji;

DROP TABLE user_post_comments;
DROP TABLE user_post_likes;
DROP TABLE user_post;
DROP TABLE users;

CREATE TABLE users (
  user_id INT IDENTITY(1,1) PRIMARY KEY,
  first_name VARCHAR(60) NOT NULL,
  last_name VARCHAR(60) NOT NULL,
  username VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  year_level VARCHAR(60) NOT NULL,
  password VARCHAR(255) NOT NULL,
  profile VARCHAR(255) NOT NULL
)

CREATE TABLE user_post (
  post_id INT IDENTITY(1,1) PRIMARY KEY,
  user_id INT NOT NULL FOREIGN KEY REFERENCES users(user_id),
  post_date VARCHAR(500) NOT NULL,
  content VARCHAR(500) NOT NULL,
  likes_count VARCHAR(500) NOT NULL,
  comments_count VARCHAR(500) NOT NULL
)

CREATE TABLE user_post_likes (
  like_id INT IDENTITY(1,1) PRIMARY KEY,
  post_id INT NOT NULL FOREIGN KEY REFERENCES user_post(post_id),
  username VARCHAR(255) NOT NULL
)

CREATE TABLE user_post_comments (
  comment_id INT IDENTITY(1,1) PRIMARY KEY,
  post_id INT NOT NULL FOREIGN KEY REFERENCES user_post(post_id),
  username VARCHAR(255) NOT NULL,
  comment VARCHAR(500) NOT NULL
)

INSERT INTO users (first_name, last_name, username, email, year_level, password, profile) VALUES
('Ira Rayzel', 'Ji', 'irarayzelji', 'irarayzel.ji.cics@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Arianne Ashley', 'Manaog', 'arianneashleymanaog', 'arianneashley.manaog.cics@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Kevin Kyle', 'Coraza', 'kevinkylecoraza', 'kevinkyle.coraza.cics@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Steve', 'De Vera', 'stevedevera', 'steve.devera.cics@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Miguel Carlo', 'Fajardo', 'miguelcarlofajardo', 'miguelcarlo.fajardo.cics@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Nickolas', 'Kim', 'nickolaskim', 'nickolas.kim.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Collin', 'Bolton', 'collinbolton', 'collin.bolton.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Junior', 'Randolph', 'juniorrandolph', 'junior.randolph.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Bernardo', 'Burgess', 'bernardoburgess', 'bernardo.burgess.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Julio', 'Daniel', 'juliodaniel', 'julio.daniel.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Brady', 'McNeil', 'bradymcneil', 'brady.mcneil.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Peggy', 'Cain', 'peggycain', 'peggy.cain.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Marietta', 'Hendricks', 'marietta.hendricks', 'mariettahendricks.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Allyson', 'Gibson', 'allysongibson', 'allyson.gibson.sci@ust.edu.ph', 'First Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Deanna', 'Sawyer', 'deannasawyer', 'deanna.sawyer.sci@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Noemi', 'Goodwin', 'noemigoodwin', 'noemi.goodwin.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Theresa', 'Schneider', 'theresaschneider', 'theresa.schneider.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Heath', 'Tran', 'heathtran', 'heath.tran.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Jesse', 'Luna', 'jesseluna', 'jesse.luna.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Zachery', 'Marquez', 'zacherymarquez', 'zachery.marquez.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Fredic', 'Banks', 'fredicbanks', 'fredic.banks.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Dana', 'Jefferson', 'danajefferson', 'dana.jefferson.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Noah', 'Finley', 'noahfinley', 'noah.finley.pharma@ust.edu.ph', 'Second Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Adrian', 'Fields', 'adrianfields', 'adrian.fields.pharma@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Jonathan', 'Harrison', 'jonathanharrison', 'jonathan.harrison.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Jesus', 'Washington', 'jesuswashington', 'jesus.washington.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Grant', 'Zamora', 'grantzamora', 'grant.zamora.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Segio', 'Goodwin', 'segiogoodwin', 'segio.goodwin.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Emmett', 'Brock', 'emmettbrock', 'emmett.brock.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Cheryl', 'Casey', 'cherylcasey', 'cheryl.casey.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Carrie', 'Ritter', 'carrieritter', 'carrie.ritter.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Tricia', 'Villegas', 'triciavillegas', 'tricia.villegas.cfad@ust.edu.ph', 'Third Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Minnie', 'Powell', 'minniepowell', 'minnie.powell.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Rosalyn', 'Durham', 'rosalyndurham', 'rosalyn.durham.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Concetta', 'Buchanan', 'concettabuchanan', 'concetta.buchanan.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Lesley', 'Skinner', 'lesleyskinner', 'lesleyskinner.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Madelyn', 'Simmons', 'madelynsimmons', 'madelyn.simmons.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Flossie', 'Berry', 'flossieberry', 'flossie.berry.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Chrystal', 'Barron', 'chrystalbarron', 'chrystal.barron.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Cecelia', 'Weaver', 'ceceliaweaver', 'cecelia.weaver.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Janette', 'Pham', 'janettepham', 'janette.pham.cthm@ust.edu.ph', 'Fourth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Lucio', 'Henson', 'luciohenson', 'lucio.henson.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Jackson', 'Heath', 'jacksonheath', 'jackson.heath.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Arnold', 'Hurley', 'arnoldhurley', 'arnold.hurley.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Eldon', 'Solis', 'eldonsolis', 'eldon.solis.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Ed', 'Gill', 'edgill', 'ed.gill.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Alden', 'Espinoza', 'alden.espinoza', 'aldenespinoza.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Joy', 'Jones', 'joyjones', 'joy.jones.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Josefina', 'Owen', 'josefina.owen', 'josefinaowen.ji.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png'),
('Juanita', 'Peck', 'juanita.peck', 'juanitapeck.archi@ust.edu.ph', 'Fifth Year', 'e10adc3949ba59abbe56e057f20f883e', '1692979068_8174.png');

INSERT INTO user_post (user_id, post_date, content, likes_count, comments_count) VALUES
('1', '10/16/23', 'I am a first year student from CICS.', '0', '0'), /*irarayzelji's post*/
('2', '10/22/23', 'I am a second year student studying Information Technology.', '0', '0'), /*arianneashleymanaog's post*/
('3', '10/15/23', 'Look at the cats in Beato >-<', '0', '0'), /*kevinkylecoraza's post*/
('3', '10/20/23', 'Ready na ba lahat sa prelims?', '0', '0'); /*kevinkylecoraza's post*/

/*arianneashleymanaog liked irarayzelji's post and increments likes count*/
INSERT INTO user_post_likes (post_id, username) VALUES
('1', 'arianneashleymanaog');
UPDATE user_post SET likes_count = '1' WHERE post_id = 1;

/*kevinkylecoraza liked irarayzelji's post and increments likes count*/
INSERT INTO user_post_likes (post_id, username) VALUES
('1', 'kevinkylecoraza');
UPDATE user_post SET likes_count = '2' WHERE post_id = 1;

/*arianneashleymanaog commented on irarayzelji's post and increments comments count*/
INSERT INTO user_post_comments (post_id, username, comment) VALUES
('1', 'arianneashleymanaog', 'Wow!');
UPDATE user_post SET comments_count = '1' WHERE post_id = 1;

/*stevedevera commented on irarayzelji's post and increments comments count*/
INSERT INTO user_post_comments (post_id, username, comment) VALUES
('1', 'stevedevera', 'Good luck Ira!');
UPDATE user_post SET comments_count = '2' WHERE post_id = 1;

/*irarayzelji liked arianneashleymanaog's post and increments likes count*/
INSERT INTO user_post_likes (post_id, username) VALUES
('2', 'irarayzelji');
UPDATE user_post SET likes_count = '1' WHERE post_id = 2;

/*miguelcarlofajardo commented on arianneashleymanaog's post and increments comments count*/
INSERT INTO user_post_comments (post_id, username, comment) VALUES
('2', 'miguelcarlofajardo', 'Go Ashley!');
UPDATE user_post SET comments_count = '1' WHERE post_id = 2;

/*show all data/tables*/
SELECT * FROM users;
SELECT * FROM user_post;
SELECT * FROM user_post_likes;
SELECT * FROM user_post_comments;

/*lists number of post per user*/
SELECT COUNT(user_post.post_id) AS post_count, users.username
FROM user_post
RIGHT JOIN users ON user_post.user_id = users.user_id
GROUP BY user_post.user_id, users.username
ORDER BY COUNT(user_post.post_id) DESC;

/*lists all users and their posts (latest first), together with its content, likes count, and who liked*/
SELECT users.username, user_post.post_date, user_post.content, 
user_post.likes_count, user_post_likes.username
FROM user_post
LEFT JOIN user_post_likes ON user_post.post_id = user_post_likes.post_id
FULL OUTER JOIN users ON users.user_id = user_post.user_id
FULL OUTER JOIN user_post_comments ON user_post.post_id = user_post_comments.post_id
GROUP BY users.user_id, users.username, post_date, content, likes_count, user_post_likes.username
ORDER BY users.user_id ASC, user_post.post_date DESC;

/*lists all users and their posts (latest first), together with its content, comments count, who commented, and their comment*/
SELECT users.username, user_post.post_date, user_post.content, 
user_post.comments_count, user_post_comments.username, user_post_comments.comment
FROM user_post
LEFT JOIN user_post_comments ON user_post.post_id = user_post_comments.post_id
FULL OUTER JOIN users ON users.user_id = user_post.user_id
GROUP BY users.user_id, users.username, post_date, content, comments_count, user_post_comments.username, user_post_comments.comment
ORDER BY users.user_id ASC, user_post.post_date DESC;

/*deleted arianneashleymanaog's post, together with all likes and comments info*/
DELETE FROM user_post_comments WHERE post_id = 2;
DELETE FROM user_post_likes WHERE post_id = 2;
DELETE FROM user_post WHERE post_id = 2;