//var device = new THREEx.DeviceOrientationState();

// global variables
    var scene, camera, renderer, mesh;
    //scene er heimurinn, camera er það sem við sjaum, renderer teiknar heiminn sem camera sér
    var meshFloor, endpoint;
    var meshWall1, meshWall2, meshWall3, meshWall4;
    var mazewall1, mazewall2, mazewall3, mazewall4, mazewall5, mazewall6, mazewall7, mazewall8, mazewall9, mazewall10, mazewall11, mazewall12;
    var hole;
    var collidableMeshList = [];//collision detection list
    var eligableForVictory = [];//detection fyrir ef þu labbar á victory point
    var loseCondition = [];//detection fyrir ef þú labbar á holu.
    var keyboard = {};
    var USE_WIREFRAME = false;
    var wpressed, dpressed, spressed, apressed;
    var ballSpeed = 0.1;
   	var countingsecs = 0;
   	var countingsecsLosing = 0;



function init(){
	//búa til camera og scene
	scene = new THREE.Scene();
	camera = new THREE.PerspectiveCamera(90, 1280/720, 0.1, 1000);

	//kasinn(player)
	mesh = new THREE.Mesh(
		new THREE.BoxGeometry(1,1,1),
		//wireframe er eins og skeleton
		new THREE.MeshBasicMaterial({color:0xa0522d, wireframe:USE_WIREFRAME})
		);
	mesh.position.y += 1;//hreyfa mesh upp 1 meter
	scene.add(mesh);

	//gólfið
	meshFloor = new THREE.Mesh(
		new THREE.PlaneGeometry(25,20, 32),//stærð
		new THREE.MeshBasicMaterial({color:0x918e7d, wireframe:USE_WIREFRAME})//útlit
		);
	meshFloor.rotation.x -= Math.PI / 2; // Rotate the floor 90 degrees
	scene.add(meshFloor);

	//veggir og staðsetningar

	//veggur 1
	meshWall1 = new THREE.Mesh(
		new THREE.BoxGeometry(25, 2),
		new THREE.MeshBasicMaterial({color:0x535146, side: THREE.DoubleSide})
		);
	meshWall1.position.y += 1;
	meshWall1.position.z += 10;
	meshWall1.castShadow = true;
	meshWall1.receiveShadow = true;
	scene.add(meshWall1);
	collidableMeshList.push(meshWall1);

	//veggur 2
	meshWall2 = new THREE.Mesh(
		new THREE.BoxGeometry(25, 2),
		new THREE.MeshBasicMaterial({color:0x535146, side: THREE.DoubleSide})
		);
	meshWall2.position.y += 1;
	meshWall2.position.z -= 10;
	meshWall2.castShadow = true;
	meshWall2.receiveShadow = true;
	scene.add(meshWall2);
	collidableMeshList.push(meshWall2);

	//veggur 3
	meshWall3 = new THREE.Mesh(
		new THREE.BoxGeometry(20, 2),
		new THREE.MeshBasicMaterial({color:0x535146, side: THREE.DoubleSide})
		);
	meshWall3.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	meshWall3.position.y += 1;
	meshWall3.position.x += 12.5;
	meshWall3.castShadow = true;
	meshWall3.receiveShadow = true;
	scene.add(meshWall3);
	collidableMeshList.push(meshWall3);

	//veggur4
	meshWall4 = new THREE.Mesh(
		new THREE.BoxGeometry(20, 2),
		new THREE.MeshBasicMaterial({color:0x535146, side: THREE.DoubleSide})
		);
	meshWall4.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	meshWall4.position.y += 1;
	meshWall4.position.x -= 12.5;
	meshWall4.castShadow = true;
	meshWall4.receiveShadow = true;
	scene.add(meshWall4);
	collidableMeshList.push(meshWall4);

	//mazewall1
	mazewall1 = new THREE.Mesh(
		new THREE.BoxGeometry(6, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall1.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	mazewall1.position.y += 0.5;
	mazewall1.position.x -= 2;
	mazewall1.position.z -= 7;
	mazewall1.castShadow = true;
	mazewall1.receiveShadow = true;
	scene.add(mazewall1);
	collidableMeshList.push(mazewall1);

	//mazewall2
	mazewall2 = new THREE.Mesh(
		new THREE.BoxGeometry(7, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall2.position.y += 0.5;
	mazewall2.position.x -= 6;
	mazewall2.position.z -= 7;
	mazewall2.castShadow = true;
	mazewall2.receiveShadow = true;
	scene.add(mazewall2);
	collidableMeshList.push(mazewall2);

	//mazewall3
	mazewall3 = new THREE.Mesh(
		new THREE.BoxGeometry(7, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall3.position.y += 0.5;
	mazewall3.position.x -= 9;
	mazewall3.position.z -= 4;
	mazewall3.castShadow = true;
	mazewall3.receiveShadow = true;
	scene.add(mazewall3);
	collidableMeshList.push(mazewall3);

	//mazewall4
	mazewall4 = new THREE.Mesh(
		new THREE.BoxGeometry(7, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall4.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	mazewall4.position.y += 0.5;
	mazewall4.position.x -= 9;
	mazewall4.position.z -= 1;
	mazewall4.castShadow = true;
	mazewall4.receiveShadow = true;
	scene.add(mazewall4);
	collidableMeshList.push(mazewall4);

	//mazewall5
	mazewall5 = new THREE.Mesh(
		new THREE.BoxGeometry(11, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall5.position.y += 0.5;
	mazewall5.position.x -= 1;
	mazewall5.position.z -= 1.65;
	mazewall5.castShadow = true;
	mazewall5.receiveShadow = true;
	scene.add(mazewall5);
	collidableMeshList.push(mazewall5);

	//mazewall6
	mazewall6 = new THREE.Mesh(
		new THREE.BoxGeometry(6, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall6.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	mazewall6.position.y += 0.5;
	mazewall6.position.x += 2;
	mazewall6.position.z += 4;
	mazewall6.castShadow = true;
	mazewall6.receiveShadow = true;
	scene.add(mazewall6);
	collidableMeshList.push(mazewall6);

	//mazewall7
	mazewall7 = new THREE.Mesh(
		new THREE.BoxGeometry(14, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall7.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	mazewall7.position.y += 0.5;
	mazewall7.position.x += 8;
	mazewall7.position.z += 0;
	mazewall7.castShadow = true;
	mazewall7.receiveShadow = true;
	scene.add(mazewall7);
	collidableMeshList.push(mazewall7);


	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(4, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x += 2.5;
	mazewall8.position.z -= 4.5;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(4, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x += 6.5;
	mazewall8.position.z -= 7.5;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(4, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x += 0;
	mazewall8.position.z -= 7.5;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(2, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x += 9;
	mazewall8.position.z -= 7;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(2, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x += 11.5;
	mazewall8.position.z -= 0.5;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(2, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x += 9;
	mazewall8.position.z += 5;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(7, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x -= 6;
	mazewall8.position.z += 3;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall8
	mazewall8 = new THREE.Mesh(
		new THREE.BoxGeometry(7, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall8.position.y += 0.5;
	mazewall8.position.x -= 6;
	mazewall8.position.z += 7;
	mazewall8.castShadow = true;
	mazewall8.receiveShadow = true;
	scene.add(mazewall8);
	collidableMeshList.push(mazewall8);

	//mazewall9
	mazewall9 = new THREE.Mesh(
		new THREE.BoxGeometry(2, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall9.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	mazewall9.position.y += 0.5;
	mazewall9.position.x -= 6;
	mazewall9.position.z += 6;
	mazewall9.castShadow = true;
	mazewall9.receiveShadow = true;
	scene.add(mazewall9);
	collidableMeshList.push(mazewall9);


	//mazewall9
	mazewall9 = new THREE.Mesh(
		new THREE.BoxGeometry(2, 2),
		new THREE.MeshBasicMaterial({color:0x353535, side: THREE.DoubleSide})
		);
	mazewall9.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	mazewall9.position.y += 0.5;
	mazewall9.position.x += 5;
	mazewall9.position.z += 6;
	mazewall9.castShadow = true;
	mazewall9.receiveShadow = true;
	scene.add(mazewall9);
	collidableMeshList.push(mazewall9);


	//endpoint
	endpoint = new THREE.Mesh(
		new THREE.BoxGeometry(1, 1),
		new THREE.MeshBasicMaterial({color:0x008000, side: THREE.DoubleSide})
		);
	endpoint.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	endpoint.position.y += 0.5;//hreyfa mesh upp 1/2 meter
	endpoint.position.x -= 3.85;
	endpoint.position.z -= 8.5;
	endpoint.castShadow = true;
	endpoint.receiveShadow = true;
	scene.add(endpoint);
	eligableForVictory.push(endpoint);


	//hole1
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	hole.position.y += 0.5;//hreyfa mesh upp 1/2 meter
	hole.position.x -= 5;
	hole.position.z -= 3;
	hole.castShadow = true;
	hole.receiveShadow = true;
	scene.add(hole);
	loseCondition.push(hole);//tvö á sama stað sem snúa öfugt á hvort annað
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.position.y += 0.5;
	hole.position.x -= 5;
	hole.position.z -= 3;
	scene.add(hole);
	loseCondition.push(hole);

	//hole2
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	hole.position.y += 0.5;
	hole.position.x += 5;
	hole.position.z -= 3;
	scene.add(hole);
	loseCondition.push(hole);//tvö á sama stað sem snúa öfugt á hvort annað
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.position.y += 0.5;
	hole.position.x += 5;
	hole.position.z -= 3;
	scene.add(hole);
	loseCondition.push(hole);

	//hole3
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	hole.position.y += 0.5;
	hole.position.x += 9.5;
	hole.position.z -= 3;
	scene.add(hole);
	loseCondition.push(hole);//tvö á sama stað sem snúa öfugt á hvort annað
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.position.y += 0.5;
	hole.position.x += 9.5;
	hole.position.z -= 3;
	scene.add(hole);
	loseCondition.push(hole);

	//hole4
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	hole.position.y += 0.5;
	hole.position.x += 6.5;
	hole.position.z += 2;
	scene.add(hole);
	loseCondition.push(hole);//tvö á sama stað sem snúa öfugt á hvort annað
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.position.y += 0.5;
	hole.position.x += 6.5;
	hole.position.z += 2;
	scene.add(hole);
	loseCondition.push(hole);

	//hole5
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	hole.position.y += 0.5;
	hole.position.x += 3.5;
	hole.position.z += 2;
	scene.add(hole);
	loseCondition.push(hole);//tvö á sama stað sem snúa öfugt á hvort annað
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.position.y += 0.5;
	hole.position.x += 3.5;
	hole.position.z += 2;
	scene.add(hole);
	loseCondition.push(hole);


	//hole6
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	hole.position.y += 0.5;
	hole.position.x -= 2;
	hole.position.z += 1.25;
	scene.add(hole);
	loseCondition.push(hole);//tvö á sama stað sem snúa öfugt á hvort annað
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.position.y += 0.5;
	hole.position.x -= 2;
	hole.position.z += 1.25;
	scene.add(hole);
	loseCondition.push(hole);


	//hole7
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.rotation.y -= Math.PI / 2; // Rotate the floor 90 degrees
	hole.position.y += 0.5;
	hole.position.x -= 11.25;
	hole.position.z -= 8.75;
	scene.add(hole);
	loseCondition.push(hole);//tvö á sama stað sem snúa öfugt á hvort annað
	hole = new THREE.Mesh(
		new THREE.BoxGeometry(0.75, 0.5),
		new THREE.MeshBasicMaterial({color:0xff0000, side: THREE.DoubleSide})
		);
	hole.position.y += 0.5;
	hole.position.x -= 11.25;
	hole.position.z -= 8.75;
	scene.add(hole);
	loseCondition.push(hole);













































	// SKYBOX/FOG
	var skyBoxGeometry = new THREE.CubeGeometry( 10000, 10000, 10000 );
	var skyBoxMaterial = new THREE.MeshBasicMaterial( { color: 0x9999ff, side: THREE.BackSide } );
	var skyBox = new THREE.Mesh( skyBoxGeometry, skyBoxMaterial );
	scene.add(skyBox);

	//myndavel
	camera.position.set(0,8.5,-5);
	camera.lookAt(mesh.position);

	//render'ar á stærðinni 1280x720
	renderer = new THREE.WebGLRenderer();
	renderer.setSize(1280,720);
	renderer.shadowMap.enabled = true;
	renderer.shadowMap.type = THREE.PCFSoftShadowMap; // default THREE.PCFShadowMap

	var light = new THREE.AmbientLight(0xffffff);
	scene.add( light );



	//setur "canvas" á html síðuna
	document.body.appendChild(renderer.domElement);



	animate();
}

function animate(){
	requestAnimationFrame(animate);

	//collission detection
	var originPoint = mesh.position.clone();
	for (var vertexIndex = 0; vertexIndex < mesh.geometry.vertices.length; vertexIndex++)
	{		
		var localVertex = mesh.geometry.vertices[vertexIndex].clone();
		var globalVertex = localVertex.applyMatrix4( mesh.matrix );
		var directionVector = globalVertex.sub( mesh.position );
		
		var ray = new THREE.Raycaster( originPoint, directionVector.clone().normalize() );
		var collisionResults = ray.intersectObjects( collidableMeshList );
		if (apressed == true && collisionResults.length > 0 && collisionResults[0].distance < directionVector.length() ) {
			console.log("u hit a wall");
			ballSpeed = 0;
			mesh.position.x -= Math.sin(mesh.rotation.y + Math.PI/2) * ballSpeed;
			mesh.position.z -= -Math.cos(mesh.rotation.y + Math.PI/2) * ballSpeed;
			camera.position.x -= Math.sin(mesh.rotation.y + Math.PI/2) * ballSpeed;
			camera.position.z -= -Math.cos(mesh.rotation.y + Math.PI/2) * ballSpeed;
		} else if(dpressed == true && collisionResults.length > 0 && collisionResults[0].distance < directionVector.length() ){
			ballSpeed = 0;
			mesh.position.x -= Math.sin(mesh.rotation.y - Math.PI/2) * ballSpeed;
			mesh.position.z -= -Math.cos(mesh.rotation.y - Math.PI/2) * ballSpeed;
			camera.position.x -= Math.sin(mesh.rotation.y - Math.PI/2) * ballSpeed;
			camera.position.z -= -Math.cos(mesh.rotation.y - Math.PI/2) * ballSpeed;
		} else if (wpressed == true && collisionResults.length > 0 && collisionResults[0].distance < directionVector.length() ) {
			ballSpeed = 0;
			mesh.position.x += Math.sin(mesh.rotation.y) * ballSpeed;
			mesh.position.z += -Math.cos(mesh.rotation.y) * ballSpeed;
			camera.position.x += Math.sin(mesh.rotation.y) * ballSpeed;
			camera.position.z += -Math.cos(mesh.rotation.y) * ballSpeed;
		} else if (spressed == true && collisionResults.length > 0 && collisionResults[0].distance < directionVector.length() ) {
			ballSpeed = 0;
			mesh.position.x -= Math.sin(mesh.rotation.y) * ballSpeed;
			mesh.position.z -= -Math.cos(mesh.rotation.y) * ballSpeed;
			camera.position.x -= Math.sin(mesh.rotation.y) * ballSpeed;
			camera.position.z -= -Math.cos(mesh.rotation.y) * ballSpeed;
		}	
			
	};	


	//endpoint detection
	var originPoint1 = mesh.position.clone();
	for (var vertexIndex1 = 0; vertexIndex1 < mesh.geometry.vertices.length; vertexIndex1++)
	{		
		var localVertex1 = mesh.geometry.vertices[vertexIndex1].clone();
		var globalVertex1 = localVertex1.applyMatrix4( mesh.matrix );
		var directionVector1 = globalVertex1.sub( mesh.position );
		
		var ray1 = new THREE.Raycaster( originPoint1, directionVector1.clone().normalize() );
		var collisionResults1 = ray1.intersectObjects( eligableForVictory );
		if (collisionResults1.length > 0 && collisionResults1[0].distance < directionVector1.length() ) {
			countingsecs++;
			if (countingsecs==50) {
			alert("You Won!")
			location.reload(true);
			}
		};
	}

	//hole detection
	var originPoint2 = mesh.position.clone();
	for (var vertexIndex2 = 0; vertexIndex2 < mesh.geometry.vertices.length; vertexIndex2++)
	{		
		var localVertex2 = mesh.geometry.vertices[vertexIndex2].clone();
		var globalVertex2 = localVertex2.applyMatrix4( mesh.matrix );
		var directionVector2 = globalVertex2.sub( mesh.position );
		
		var ray2 = new THREE.Raycaster( originPoint2, directionVector2.clone().normalize() );
		var collisionResults2 = ray2.intersectObjects( loseCondition );
		if (collisionResults2.length > 0 && collisionResults2[0].distance < directionVector2.length() ) {
			console.log("ur falling down a hole");
			countingsecsLosing++;
			if (countingsecsLosing==10) {
			alert("You fell in a hole and have to restart!")
			location.reload(true);
			}
		};
	}

	//snúa mesh'inu sem við bjuggum til

	camera.lookAt(mesh.position);

	// Keyboard movement inputs
	if(keyboard[87]){ // W key
		mesh.position.x -= Math.sin(mesh.rotation.y) * ballSpeed;
		mesh.position.z -= -Math.cos(mesh.rotation.y) * ballSpeed;
		camera.position.x -= Math.sin(mesh.rotation.y) * ballSpeed;
		camera.position.z -= -Math.cos(mesh.rotation.y) * ballSpeed;
		wpressed = true;
	}
	if(keyboard[83]){ // S key
		mesh.position.x += Math.sin(mesh.rotation.y) * ballSpeed;
		mesh.position.z += -Math.cos(mesh.rotation.y) * ballSpeed;
		camera.position.x += Math.sin(mesh.rotation.y) * ballSpeed;
		camera.position.z += -Math.cos(mesh.rotation.y) * ballSpeed;
		spressed = true;
	}
	if(keyboard[65]){ // A key
		// Redirect motion by 90 degrees
		mesh.position.x += Math.sin(mesh.rotation.y + Math.PI/2) * ballSpeed;
		mesh.position.z += -Math.cos(mesh.rotation.y + Math.PI/2) * ballSpeed;
		camera.position.x += Math.sin(mesh.rotation.y + Math.PI/2) * ballSpeed;
		camera.position.z += -Math.cos(mesh.rotation.y + Math.PI/2) * ballSpeed;
		apressed = true;
	}
	if(keyboard[68]){ // D key
		mesh.position.x += Math.sin(mesh.rotation.y - Math.PI/2) * ballSpeed;
		mesh.position.z += -Math.cos(mesh.rotation.y - Math.PI/2) * ballSpeed;
		camera.position.x += Math.sin(mesh.rotation.y - Math.PI/2) * ballSpeed;
		camera.position.z += -Math.cos(mesh.rotation.y - Math.PI/2) * ballSpeed;
		dpressed = true;
	}
	/*
	// Keyboard turn inputs
	if(keyboard[37]){ // left arrow key
		mesh.rotation.y -= (Math.PI*0.02);
	}
	if(keyboard[39]){ // right arrow key
		mesh.rotation.y += (Math.PI*0.02);
	}
	*/
	//teikna scene frá sjónarhorni camera
	renderer.render(scene, camera);
		}

function keyDown(event){
	keyboard[event.keyCode] = true;
}

function keyUp(event){
	keyboard[event.keyCode] = false;
	wpressed = false;
	apressed = false;
	dpressed = false;
	spressed = false;
	ballSpeed = 0.1;
}

window.addEventListener('keydown', keyDown);
window.addEventListener('keyup', keyUp);

window.onload = init;
